using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface IProjectService
{
    Task<bool> IsProjectCompleted(string userId, int projectId);
    Task<int> PostArticle(DashboardProject project);
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

    public async Task<bool> IsProjectCompleted(string userId, int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var result =  await context.DashboardProjects
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
                    var result =  await context.SaveChangesAsync();

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
}
