using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.DTOs;

namespace TCSA.V2.Services;

public interface IPeerReviewService
{
    Task MarkCodeReviewAsCompleted(string reviewerId, int dashboardProjectId, string userId);
    Task<List<DashboardProject>> GetProjectsForPeerReview(string reviewerId);
    Task AssignUserToCodeReview(string userId, int id);
    Task ReleaseUserFromCodeReview(string userId, int id);
    string GetRevieweeName(string revieweeId);
    Task<ApplicationUser> GetUserForPeerReview(string reviewerId);
    Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId);
    Task<int> GetAvailablePeerReviewsCount(string reviewerId);
}
public class PeerReviewService : IPeerReviewService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<UserActivityService> _logger;

    public PeerReviewService(ILogger<UserActivityService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task MarkCodeReviewAsCompleted(string reviewerId, int dashboardProjectId, string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var currentRevieweePoints = context.Users
                    .Where(x => x.Id == userId)
                    .Select(x => x.ExperiencePoints)
                    .FirstOrDefault();

                var currentReviewerPoints = context.Users
                   .Where(x => x.Id == reviewerId)
                   .Select(x => x.ExperiencePoints)
                   .FirstOrDefault();

                var reviewedProjects = await context.UserActivity
                    .Where(x => x.AppUserId.ToString() == reviewerId && x.ActivityType == ActivityType.CodeReviewCompleted)
                    .ToListAsync();
                    
                var dashboardProject = await context.DashboardProjects.FirstOrDefaultAsync(x => x.Id == dashboardProjectId);

                var academyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == dashboardProject.ProjectId);

                dashboardProject.IsPendingReview = false;
                dashboardProject.IsPendingNotification = true;
                dashboardProject.IsCompleted = true;

                context.DashboardProjects
                    .Update(dashboardProject);

                context.UserActivity.AddRange(new AppUserActivity
                {
                    ProjectId = dashboardProject.ProjectId,
                    AppUserId = dashboardProject.AppUserId,
                    DateSubmitted = DateTime.UtcNow,
                    ActivityType = ActivityType.ProjectCompleted
                },
                new AppUserActivity
                {
                    ProjectId = dashboardProject.ProjectId,
                    AppUserId = reviewerId,
                    DateSubmitted = DateTime.UtcNow,
                    ActivityType = ActivityType.CodeReviewCompleted
                });

                var reviewer = await context.Users
                    .Where(x => x.Id == reviewerId).FirstAsync();

                if ((reviewer != null && reviewedProjects != null) && (reviewer.ReviewExperiencePoints == 0 && reviewedProjects.Count > 0))
                {
                    //This has to be retroactive, so if some user has reviews but no points, it will calculate them first.
                    //This is the same as the leaderboard calculation, but just in case the leaderboard calculation is never done and some user escapes the check, we make sure that the points are set here.
                    foreach (AppUserActivity review in reviewedProjects)
                    {
                        var reviewAcademyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == review.ProjectId);

                        reviewer.ReviewExperiencePoints = reviewer.ReviewExperiencePoints + reviewAcademyProject.ExperiencePoints;
                    }
                    //If reviewer has no experience points set, that means the reviewedProjects column is also not set yet.
                    reviewer.ReviewedProjects = reviewedProjects.Count;
                }

                context.Users
                    .Where(x => x.Id == dashboardProject.AppUserId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentRevieweePoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentReviewerPoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ReviewExperiencePoints, academyProject.ExperiencePoints + reviewer.ReviewExperiencePoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ReviewedProjects, reviewer.ReviewedProjects + 1));

                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(MarkCodeReviewAsCompleted)}");
        }
    }

    public async Task<List<DashboardProject>> GetProjectsForPeerReview(string reviewerId)
    {
        var url = "https://github.com/TheCSharpAcademy/CodeReviews";
        var beginnerProjects = new List<int> { 53, 11, 12, 13 };

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var level = context.Users.FirstOrDefault(x => x.Id == reviewerId).Level;

                if (level < Level.Yellow)
                {
                    return new List<DashboardProject> { };
                }
                else if (level > Level.Yellow)
                {
                    beginnerProjects.AddRange(new List<int> { 14, 15, 16, 17 });
                }

                if (level > Level.Red)
                {
                    beginnerProjects.AddRange(new List<int> { 18, 19, 20, 21 });
                }

                var reviewProjects = context.UserReviews
                    .Where(x => x.AppUserId != reviewerId)
                    .Select(x => x.DashboardProjectId)
                    .ToList();

                return await context.DashboardProjects
                .AsSplitQuery()
                .Include(x => x.AppUser)
                .Where(x => x.IsPendingReview
                   && beginnerProjects.Contains(x.ProjectId)
                   && !reviewProjects.Contains(x.Id)
                   && x.GithubUrl.StartsWith(url))
                .OrderBy(x => x.DateSubmitted)
                .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetProjectsForPeerReview)}");
            return null;
        }
    }

    public async Task<int> GetAvailablePeerReviewsCount(string reviewerId)
    {
        var url = "https://github.com/TheCSharpAcademy/CodeReviews";
        var beginnerProjects = new List<int> { 53, 11, 12, 13 };

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var level = context.Users.FirstOrDefault(x => x.Id == reviewerId)?.Level;

                if (level < Level.Yellow)
                {
                    return 0;
                }
                else if (level > Level.Yellow)
                {
                    beginnerProjects.AddRange(new List<int> { 14, 15, 16, 17 });
                }

                if (level > Level.Red)
                {
                    beginnerProjects.AddRange(new List<int> { 18, 19, 20, 21 });
                }

                var reviewProjects = context.UserReviews
                    .Select(x => x.DashboardProjectId)
                    .ToList();

                var count = await context.DashboardProjects
                    .Where(x => x.IsPendingReview
                        && beginnerProjects.Contains(x.ProjectId)
                        && !reviewProjects.Contains(x.Id)
                        && x.GithubUrl.StartsWith(url))
                    .CountAsync();

                return count;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetProjectsForPeerReview)}");
            return 0;
        }
    }

    public async Task AssignUserToCodeReview(string userId, int id)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.UserReviews.AddAsync(new UserReview
            {
                AppUserId = userId,
                DashboardProjectId = id
            });

            await context.SaveChangesAsync();
        }
    }

    public async Task ReleaseUserFromCodeReview(string userId, int id)
    {
        using (var context = _factory.CreateDbContext())
        {
            var userReview = await context.UserReviews
                .FirstOrDefaultAsync(x => x.AppUserId == userId && x.DashboardProjectId == id);

            if (userReview is null)
            {
                return;
            }

            context.UserReviews.Remove(userReview);
            await context.SaveChangesAsync();
        }
    }

    public string GetRevieweeName(string revieweeId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var reviewee = context.AspNetUsers
                    .Where(x => x.Id.Equals(revieweeId))
                    .Select(x => new
                    {
                        DisplayName = string.IsNullOrEmpty(x.DisplayName) ? x.FirstName + " " + x.LastName : x.DisplayName,
                        GithubUsername = string.IsNullOrEmpty(x.GithubUsername) ? "" : x.GithubUsername
                    })
                    .FirstOrDefault();

                return reviewee?.DisplayName == " " ? reviewee?.GithubUsername : reviewee?.DisplayName;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetRevieweeName)}");
            return null;
        }
    }

    public async Task<ApplicationUser> GetUserForPeerReview(string reviewerId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                    .Include(x => x.CodeReviewProjects)
                    .FirstOrDefaultAsync(x => x.Id.Equals(reviewerId));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserForPeerReview)}");
            return null;
        }
    }

    // TODO CHANGE THIS, LOOKS LIKE A VERY EXPENSIVE QUERY
    public async Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId)
    {
        var result = new List<CodeReviewDetail>();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var reviews = await context.UserReviews
                    .Where(x => x.AppUserId == userId)
                    .ToListAsync();

                foreach (var review in reviews)
                {
                    var project = context.DashboardProjects
                        .AsNoTracking()
                        .Include(x => x.AppUser)
                        .SingleOrDefault(x => x.Id.Equals(review.DashboardProjectId));

                    if (project != null)
                    {
                        result.Add(new CodeReviewDetail
                        {
                            ProjectId = project.ProjectId,
                            IsCompleted = project.IsCompleted || project.IsArchived,
                            UserName = $"{project.AppUser.FirstName + project.AppUser.LastName}"
                        });
                    }

                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetCodeReviewDetails)}");
            return null;
        }

        return result;
    }
}
