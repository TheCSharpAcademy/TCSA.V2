using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.DTOs;

namespace TCSA.V2.Services;

public interface ILeaderboardService
{
    Task<int> GetUserRanking(string userId);
    Task<List<AppUserForLeaderboard>> GetUsersForLeaderboard(int pageNumber);
    Task<List<AppUserForLeaderboard>> GetUserForReviewLeaderboard();
    Task<List<AppUserForLeaderboard>> GetUsersForLeaderboard();
}
public class LeaderboardService : ILeaderboardService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<UserActivityService> _logger;

    public LeaderboardService(ILogger<UserActivityService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task<int> GetUserRanking(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var rankingParameter = new SqlParameter("ranking", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                var parameters = new[]
                {
                    new SqlParameter("userId", userId),
                    rankingParameter
                };

                context.Database.ExecuteSqlRaw("EXEC GetRanking @userId, @ranking OUT", parameters);

                if (rankingParameter.Value != DBNull.Value)
                {
                    return (int)rankingParameter.Value;
                }

                return -1;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserRanking)}");
            return 0;
        }
    }

    public async Task<List<AppUserForLeaderboard>> GetUserForReviewLeaderboard()
    {
        var users = new List<ApplicationUser>();
        var result = new List<AppUserForLeaderboard>();
        var index = 0;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = await context.Users
                .Where(x => x.CodeReviewProjects != null || x.CodeReviewProjects.Count > 0)
                .ToListAsync();

                foreach (ApplicationUser user in users)
                {
                    if (user.ReviewExperiencePoints is null || user.ReviewExperiencePoints == 0)
                    {
                        foreach (UserReview review in user.CodeReviewProjects!)
                        {
                            var dashboardProject = await context.DashboardProjects.FirstOrDefaultAsync(x => x.Id == review.DashboardProjectId);

                            var academyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == dashboardProject.ProjectId);

                            user.ReviewExperiencePoints = user.ReviewExperiencePoints + academyProject.ExperiencePoints;
                        }

                            context.Users
                           .Where(x => x.Id == user.Id)
                           .ExecuteUpdate(y => y.SetProperty(u => u.ReviewExperiencePoints, user.ExperiencePoints));

                        await context.SaveChangesAsync();
                    }

                    var userForLeaderboard = new AppUserForLeaderboard
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Country = user.Country,
                        Level = user.Level,
                        DisplayName = user.DisplayName,
                        ExperiencePoints = user.ExperiencePoints,
                        Ranking = index
                    };

                    userForLeaderboard.GithubUsername = user.GithubUsername ?? string.Empty;
                    userForLeaderboard.LinkedInUrl = user.LinkedInUrl ?? string.Empty;

                    result.Add(userForLeaderboard);
                }

                return result;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUsersForLeaderboard)}");
            return null;
        }
    }

    public async Task<List<AppUserForLeaderboard>> GetUsersForLeaderboard(int pageNumber)
    {
        var users = new List<ApplicationUser>();
        var result = new List<AppUserForLeaderboard>();
        var index = pageNumber == 0 ? 0 : pageNumber * 50;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = await context.Users
                .Where(x => x.ExperiencePoints > 0)
                .OrderByDescending(x => x.ExperiencePoints)
                .ThenBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Skip(pageNumber * 50)
                .Take(50)
                .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUsersForLeaderboard)}");
            return null;
        }

        foreach (var user in users)
        {
            index++;
            var userForLeaderboard = new AppUserForLeaderboard
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Country = user.Country,
                Level = user.Level,
                DisplayName = user.DisplayName,
                ExperiencePoints = user.ExperiencePoints,
                Ranking = index
            };

            userForLeaderboard.GithubUsername = user.GithubUsername ?? string.Empty;
            userForLeaderboard.LinkedInUrl = user.LinkedInUrl ?? string.Empty;

            result.Add(userForLeaderboard);
        }

        return result;
    }

    public async Task<List<AppUserForLeaderboard>> GetUsersForLeaderboard()
    {
        var queryYear = new DateTime(2024, 1, 1);
        var users = new List<ApplicationUser>();
        var result = new List<AppUserForLeaderboard>();
        var index = 0;

        var projects = ProjectHelper.GetProjects();
        var articles = ArticleHelper.GetArticles();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = context.Users
                    .Where(x => x.DashboardProjects.Any(x => x.DateSubmitted > queryYear))
                    .Include(x => x.DashboardProjects.Where(x => x.DateSubmitted > queryYear && x.IsCompleted))
                    .Include(x => x.CodeReviewProjects)
                    .Include(x => x.Issues)
                    .ToList();

                foreach (var user in users)
                {
                    var ids = user.DashboardProjects?
                      .Select(x => x.ProjectId)
                      .ToList();

                    var issues = user.Issues;

                    user.ExperiencePoints = 0;

                    foreach (int id in ids)
                    {
                        Console.WriteLine($"User: {user.Id}, Project: {id}");

                        if (projects.Any(x => x.Id == id))
                        {
                            user.ExperiencePoints = projects.Single(x => x.Id == id).ExperiencePoints + user.ExperiencePoints;
                        }
                        else if (articles.Any(x => x.Id == id))
                        {
                            user.ExperiencePoints = articles.Single(x => x.Id == id).ExperiencePoints + user.ExperiencePoints;
                        }
                        else
                        {
                            user.ExperiencePoints = issues.Single(x => x.ProjectId == id).ExperiencePoints + user.ExperiencePoints;
                        }
                    }
                }
            }

            foreach (var user in users.OrderByDescending(x => x.ExperiencePoints))
            {
                index++;
                var userForLeaderboard = new AppUserForLeaderboard
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Country = user.Country,
                    Level = user.Level,
                    DisplayName = user.DisplayName,
                    ExperiencePoints = user.ExperiencePoints,
                    Ranking = index
                };

                userForLeaderboard.GithubUsername = user.GithubUsername ?? string.Empty;
                userForLeaderboard.LinkedInUrl = user.LinkedInUrl ?? string.Empty;

                result.Add(userForLeaderboard);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUsersForLeaderboard)}");
            return null;
        }

        return result;
    }
}
