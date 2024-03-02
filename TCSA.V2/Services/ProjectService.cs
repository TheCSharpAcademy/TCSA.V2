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

    public ProjectService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<bool> IsProjectCompleted(string userId, int projectId)
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.DashboardProjects
                .AnyAsync(x => x.ProjectId == projectId && x.AppUserId == userId);
        }
    }

    public async Task<int> PostArticle(DashboardProject project)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var alreadyExists = await context.DashboardProjects
                .AnyAsync(x => x.ProjectId == project.Id && x.AppUserId == project.AppUserId);

                if (!alreadyExists)
                {
                    await context.DashboardProjects.AddAsync(project);
                    return await context.SaveChangesAsync();
                }

                return 0;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }
}
