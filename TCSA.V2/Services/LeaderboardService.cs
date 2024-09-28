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
    Task<List<AppUserForReviewLeaderboard>> GetUserForReviewLeaderboard();
    Task PopulateReview();
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

    public async Task PopulateReview()
    {
        using (var context = _factory.CreateDbContext())
        {
            var users = await context.AspNetUsers
     .Where(x => x.CodeReviewProjects.Any()) // Filter users with projects
     .ToListAsync();

            var projects = ProjectHelper.GetProjects();
            var invalidprojectIds = new List<int>();

            foreach (var u in users)
            {
                var user = await context.AspNetUsers
                    .Include(x => x.CodeReviewProjects)
                    .FirstOrDefaultAsync(x => x.Id == u.Id);

                var projectIds = user.CodeReviewProjects.Select(x => x.DashboardProjectId).ToList();   

                foreach (var project in user.CodeReviewProjects)
                {
                    var dbProjects = context.DashboardProjects.Where(x => projectIds.Contains(x.Id) && x.IsCompleted).ToList();

                    var dbprj = dbProjects.FirstOrDefault(x => x.Id == project.DashboardProjectId);

                    if (dbprj == null)
                    {
                        invalidprojectIds.Add(project.DashboardProjectId);
                    }
                    else
                    {
                        var projectId = dbprj.ProjectId;
                        user.ReviewExperiencePoints += projects.First(x => x.Id == projectId).ExperiencePoints;
                    }
                }
            
            }

            await context.SaveChangesAsync();

            
            Console.WriteLine("Done");

        }
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

    public async Task<List<AppUserForReviewLeaderboard>> GetUserForReviewLeaderboard()
    {
        var users = new List<ApplicationUser>();
        var result = new List<AppUserForReviewLeaderboard>();
        var index = 1;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = await context.Users
                .Include(x => x.CodeReviewProjects)
                .Where(x => x.ReviewExperiencePoints > 0)
                .ToListAsync();

                foreach (ApplicationUser user in users)
                {
                    var userForLeaderboard = new AppUserForReviewLeaderboard
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Country = user.Country,
                        DisplayName = user.DisplayName,
                        TotalXp = user.ReviewExperiencePoints,
                        ReviewsNumber = user.CodeReviewProjects.Count()
                    };

                    result.Add(userForLeaderboard);
                }

                result = result
                    .OrderByDescending(x => x.TotalXp)
                    .Take(50)
                    .ToList();

                foreach (var user in result)
                {
                    user.Ranking = index;
                    index++;
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
}
