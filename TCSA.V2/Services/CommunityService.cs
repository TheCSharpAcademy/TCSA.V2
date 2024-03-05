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
    Task AssignUserToIssue(string id, Issue issue);
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
    public async Task AssignUserToIssue(string id, Issue issue)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.DashboardProjects.AddAsync(new DashboardProject
            {
                GithubUrl = "Not yet",
                AppUserId = id,
                ProjectId = issue.ProjectId,
                DateSubmitted = DateTime.UtcNow,
            });
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
