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
    Task<List<DashboardProject>> GetProjectsForPeerReview(Level level);
    Task AssignUserToCodeReview(string userId, int id);
    string GetRevieweeName(string revieweeId);
    Task<ApplicationUser> GetUserForPeerReview(string reviewerId);
    Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId);
    Task<int> GetAvailablePeerReviewsCount(Level level);
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

                context.Users
                    .Where(x => x.Id == dashboardProject.AppUserId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentRevieweePoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentReviewerPoints));

                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(MarkCodeReviewAsCompleted)}");
        }
    }

    public async Task<List<DashboardProject>> GetProjectsForPeerReview(Level level)
    {
        var url = "https://github.com/TheCSharpAcademy/CodeReviews";

        var reviewableProjects = new List<int> { 53, 11, 12, 13 };

        if (level > Level.Yellow)
        {
            reviewableProjects.AddRange(new List<int> { 14, 15, 16, 17 });
        }

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var usersReviewProjects = context.UserReviews
                    .Select(x => x.DashboardProjectId)
                    .ToList();

                return await context.DashboardProjects
                .AsSplitQuery()
                .Include(x => x.AppUser)
                .Where(x => x.IsPendingReview
                   && reviewableProjects.Contains(x.ProjectId)
                   && !usersReviewProjects.Contains(x.Id)
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

    public async Task<int> GetAvailablePeerReviewsCount(Level level)
    {
        var url = "https://github.com/TheCSharpAcademy/CodeReviews";
        var reviewableProjects = new List<int> { 53, 11, 12, 13 };

        if (level > Level.Yellow)
        {
            reviewableProjects.AddRange(new List<int> { 14, 15, 16, 17 });
        }

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var usersReviewProjects = context.UserReviews
                    .Select(x => x.DashboardProjectId)
                    .ToList();

                var count = await context.DashboardProjects
                    .Where(x => x.IsPendingReview
                   && reviewableProjects.Contains(x.ProjectId)
                   && !usersReviewProjects.Contains(x.Id)
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
                        DisplayName = string.IsNullOrEmpty(x.DisplayName) ? x.FirstName + " " + x.LastName : x.DisplayName
                    })
                    .FirstOrDefault();

                return reviewee?.DisplayName;
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
                            IsCompleted = project.IsCompleted,
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
