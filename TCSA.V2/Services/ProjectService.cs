using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface IProjectService
{
    Task<bool> IsProjectCompleted(string userId, int projectId);
    Task<int> PostArticle(DashboardProject project);
    Task<List<int>> GetCompletedProjectsById(string userId);
    Task<List<int>> GetPendingProjects(string userId);
    Task<List<DashboardProject>> GetDetailedProjectsById(string userId);
    Task<int> MarkCertificateAsCompleted(string userId, int currentPoints);
}
public class ProjectService : IProjectService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<ProjectService> _logger;

    public ProjectService(ILogger<ProjectService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task<List<int>> GetCompletedProjectsById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .Where(x => x.AppUserId == userId)
                    .Select(x => x.ProjectId)
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetCompletedProjectsById)}");
            return null;
        }
    }

    public async Task<List<DashboardProject>> GetDetailedProjectsById(string userId)
    {
        var projects = new List<DashboardProject>();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .Where(x => x.AppUserId == userId)
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(IsProjectCompleted)}");
            return null;
        }
    }

    public async Task<bool> IsProjectCompleted(string userId, int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var result = await context.DashboardProjects
                    .AnyAsync(x => x.ProjectId == projectId && x.AppUserId == userId);

                _logger.LogInformation($"{nameof(IsProjectCompleted)} executed correctly");

                return result;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(IsProjectCompleted)}");
            return false;
        }
    }

    public async Task<int> PostArticle(DashboardProject project)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var alreadyExists = await context.DashboardProjects
                .AnyAsync(x => x.ProjectId == project.ProjectId && x.AppUserId == project.AppUserId);

                if (!alreadyExists)
                {
                    await context.DashboardProjects.AddAsync(project);
                    var result = await context.SaveChangesAsync();

                    _logger.LogInformation($"{nameof(PostArticle)} executed correctly");
                    return result;
                }

                return 0;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(PostArticle)}");
            return 0;
        }
    }

    public async Task<int> MarkCertificateAsCompleted(string userId, int currentPoints)
    {
        var project = ProjectHelper.GetProjects().Single(x => x.Id == 75);

        using (var context = _factory.CreateDbContext())
        {
            var dashboardProject = new DashboardProject
            {
                ProjectId = 75,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                IsCompleted = true,
                IsPendingNotification = true,
                IsPendingReview = false,
                DateRequestedChange = DateTime.UtcNow,
                GithubUrl = "Not applicable"
            };

            context.DashboardProjects
                .Add(dashboardProject);

            context.UserActivity.Add(new AppUserActivity
            {
                ProjectId = 75,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                ActivityType = ActivityType.ProjectCompleted
            });

            context.Users
                .Where(x => x.Id == userId)
                .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, project.ExperiencePoints + currentPoints));

            return await context.SaveChangesAsync();
        }
    }

    public async Task<List<int>> GetPendingProjects(string userId)
    {
        var projects = new List<int>();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .Where(x => x.AppUserId == userId && x.IsPendingReview)
                    .Select(x => x.ProjectId)
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetCompletedProjectsById)}");
            return null;
        }
    }
}
