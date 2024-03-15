using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface ICommunityService
{
    Task<DashboardProject> GetIssueById(int id);
    Task<int> PostIssue(DashboardProject project, string id, bool isCommunityProject = false);
    Task<int> GetAvailableIssues();
    Task AssignUserToIssue(string appUserId, CommunityIssue issue);
    Task<int> GetAvailableIssuesForDashboard();
    Task<CommunityIssue> GetIssueByProjectId(int projectId);
    Task<List<int>> GetIssuesIds();
    Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId);
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

    public async Task<int> GetAvailableIssues()
    {
        var allIssues = IssueHelper.GetIssues();
        var issueIdsCsv = string.Join(",", allIssues.Select(issue => issue.Id));

        using (var context = _factory.CreateDbContext())
        {
            var parameter = new SqlParameter("@IssueIds", SqlDbType.VarChar)
            {
                Value = issueIdsCsv
            };

            var result = await context.Database.ExecuteSqlRawAsync("EXEC CountNonExistingIssues @IssueIds", parameter);

            return result;
        }
    }

    public async Task<int> GetAvailableIssuesForDashboard()
    {
        var allIssues = IssueHelper.GetIssues().Where(x => !x.IsClosed).ToList();

        var issueIds = allIssues.Select(issue => issue.Id).ToList();

        using (var context = _factory.CreateDbContext())
        {
            var existingIssueIds = await context.DashboardProjects
                                                .Where(dp => issueIds.Contains(dp.ProjectId))
                                                .Select(dp => dp.ProjectId)
                                                .ToListAsync();

            var nonExistingCount = issueIds.Except(existingIssueIds).Count();

            return nonExistingCount;
        }
    }

    public async Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.Where(x => string.IsNullOrEmpty(x.AppUserId) || x.AppUserId.Equals(appUserId)).ToListAsync();
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
