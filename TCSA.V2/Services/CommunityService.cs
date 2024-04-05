using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface ICommunityService
{
    Task<int> PostIssue(DashboardProject project, string id, bool isCommunityProject = false);
    Task AssignUserToIssue(string appUserId, CommunityIssue issue);
    Task<int> GetAvailableIssuesCount();
    Task<CommunityIssue> GetIssueByProjectId(int projectId);
    Task<List<int>> GetIssuesIds();
    Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId);
    Task CreateIssue(CommunityIssue form);
    Task<List<CommunityIssue>> GetIssuesForAdmin();
    Task<int> GetCompletedIssuesCount(string appUserId);
}

public class CommunityService : ICommunityService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<CommunityService> _logger;

    public CommunityService(ILogger<CommunityService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }
    public async Task<int> GetCompletedIssuesCount(string appUserId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.Where(x => x.AppUserId == appUserId && x.IsClosed).CountAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetCompletedIssuesCount)}");
            return 0;
        }
    }

    public async Task<List<CommunityIssue>> GetIssuesForAdmin()
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.Where(x => x.IsClosed == false).ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetIssuesForAdmin)}");
            return null;
        }
    }

    public async Task CreateIssue(CommunityIssue issue)
    {
        issue.IconUrl = issue.Type switch
        {
            IssueType.Translation => "icons8-foreign-language-66.png",
            IssueType.Bugfix => "icons8-insect-64.png",
            IssueType.Feature => "icons8-feature-64.png",
            IssueType.Infrastructure => "icons8-infrastructure-55.png"
        };    
            
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var lastIssue = await context.Issues.OrderBy(x => x.ProjectId).LastAsync();
                issue.ProjectId = lastIssue.ProjectId + 1;
                //TODO check in ProjectHelper/ArticleHelper if there isn't a higher Id.

                await context.Issues.AddAsync(issue);

                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async Task<List<int>> GetIssuesIds()
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.Select(x => x.ProjectId).ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetIssuesIds)}");
            return null;
        }
    }

    public async Task<CommunityIssue> GetIssueByProjectId(int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.FirstOrDefaultAsync(x => x.ProjectId == projectId);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetIssueByProjectId)}");
            return null;
        }
    }

    public async Task AssignUserToIssue(string appUserId, CommunityIssue issue)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.DashboardProjects.AddAsync(new DashboardProject
            {
                GithubUrl = "Not yet",
                AppUserId = appUserId,
                ProjectId = issue.ProjectId,
                DateSubmitted = DateTime.UtcNow,
            });

            await context.Issues.Where(x => x.ProjectId == issue.ProjectId)
                 .ExecuteUpdateAsync(y => y.SetProperty(u => u.AppUserId, appUserId));

            await context.SaveChangesAsync();
        }
    }

    public async Task<DashboardProject> GetIssueById(int id)
    {
        using (var context = _factory.CreateDbContext())
        {
            return context.DashboardProjects.FirstOrDefault(x => x.ProjectId == id);
        }
    }

    public async Task<int> GetAvailableIssuesCount()
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.Issues
                .Where(x => string.IsNullOrEmpty(x.AppUserId))
                .CountAsync();

        }
    }

    public async Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues
                    .Where(x => !x.IsClosed)
                    .Where(x => string.IsNullOrEmpty(x.AppUserId) || x.AppUserId.Equals(appUserId)).ToListAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetIssueByProjectId)}");
            return null;
        }
    }

    public async Task<int> PostIssue(DashboardProject project, string id, bool isCommunityProject = false)
    {
        if (project.GithubUrl == null)
        {
            project.GithubUrl = "Project is article";
        }
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var projectCheck = await context.DashboardProjects.FirstOrDefaultAsync(x => x.AppUserId == id && x.ProjectId == project.ProjectId);


                if (projectCheck == null)
                {
                    await context.DashboardProjects.AddAsync(project);
                }
                else
                {
                    if (isCommunityProject)
                    {
                        projectCheck.IsPendingReview = true;
                        projectCheck.GithubUrl = project.GithubUrl;
                        context.DashboardProjects.Update(projectCheck);
                    }
                }

                return await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }

}
