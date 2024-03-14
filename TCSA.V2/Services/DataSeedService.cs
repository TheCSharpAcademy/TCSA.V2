using Bogus;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.Forms;

namespace TCSA.V2.Services;

public interface IDataSeedService
{
    Task SeedData(DataSeedForm form);
    Task SeedIssues();
}

public class DataSeedService: IDataSeedService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public DataSeedService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task SeedIssues()
    {
        var communityIssues = new List<CommunityIssue>();
        var currentIssues = new List<int>();

        using (var context = _factory.CreateDbContext())
        {
            currentIssues = context.Issues.Select(x => x.ProjectId).ToList();

            foreach (var issue in IssueHelper.GetIssues())
            {
                if (!currentIssues.Contains(issue.ProjectId))
                {
                    communityIssues.Add(new CommunityIssue
                    {
                        AppUserId = "",
                        ProjectId = issue.ProjectId,
                        CommunityProjectId = issue.CommunityProjectId,
                        GithubUrl = issue.GithubUrl,
                        Title = issue.Description,
                        IconUrl = issue.IconUrl,
                        ExperiencePoints = issue.ExperiencePoints,
                        IsClosed = issue.IsClosed
                    });
                }
            }

            try
            {
                await context.Issues.AddRangeAsync(communityIssues);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public async Task SeedData(DataSeedForm form)
    {
        var appUsers = GetAppUsersForSeedData(form);
        var userActivity = GetUserActivity(appUsers);

        using (var context = _factory.CreateDbContext())
        {
            try
            {
                await context.AspNetUsers.AddRangeAsync(appUsers);
                await context.UserActivity.AddRangeAsync(userActivity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private List<AppUserActivity> GetUserActivity(List<ApplicationUser> appUsers)
    {
        var activity = new List<AppUserActivity>();

        foreach(var appUser in appUsers)
        {
            foreach(var project in appUser.DashboardProjects)
            {
                activity.Add(new AppUserActivity
                {
                    AppUserId = appUser.Id,
                    ProjectId = project.Id,
                    ActivityType = ActivityType.ProjectSubmitted,
                    DateSubmitted = project.DateSubmitted
                });

                activity.Add(new AppUserActivity
                {
                    AppUserId = appUser.Id,
                    ProjectId = project.Id,
                    ActivityType = ActivityType.ProjectCompleted,
                    DateSubmitted = project.DateSubmitted.AddDays(1)
                });
            }
        }

        return activity;
    }

    private List<ApplicationUser> GetAppUsersForSeedData(DataSeedForm form)
    {
        var users = new List<ApplicationUser>();

        for (int i = 0; i < form.NumberOfUsers ; i++)
        {
            var faker = new Faker("en");
            Guid newGuid = Guid.NewGuid();
            var projects = GetProjects(form.NumberOfProjects, newGuid.ToString());
            var experiencePoints = GetExperiencePoints(projects.Select(x => x.ProjectId).ToArray());

            users.Add(new ApplicationUser
            {
                Id = newGuid.ToString(),
                FirstName = faker.Person.FirstName,
                LastName = faker.Person.LastName,
                Email = faker.Person.Email,
                Country = faker.Address.Country(),
                ExperiencePoints = experiencePoints,
                DashboardProjects = projects,
            }); 
        }

        return users;
    }

    private int GetExperiencePoints(int[] ints)
    {
        var points = 0;

        var articleIds = ArticleHelper.GetArticles().Select(x => x.Id);
        var projectIds = ProjectHelper.GetProjects().Select(x => x.Id);
        var issueIds = IssueHelper.GetIssues().Select(x => x.Id);
    
        foreach (int i in ints)
        {
            if (articleIds.Contains(i))
            {
                points += ArticleHelper.GetArticles().Single(x => x.Id == i).ExperiencePoints;
            }

            if (projectIds.Contains(i))
            {
                points += ProjectHelper.GetProjects().Single(x => x.Id == i).ExperiencePoints;
            }

            if (issueIds.Contains(i))
            {
                points += IssueHelper.GetIssues().Single(x => x.Id == i).ExperiencePoints;
            }
        }

        return points;
    }

    private List<DashboardProject> GetProjects(int numberOfProjects, string userId)
    {
        var projects = new List<DashboardProject>();

        for (int i = 0; i < numberOfProjects; i++)
        {
            var faker = new Faker("en");
            var randomDate = faker.Date.Between(new DateTime(2023, 1, 1), new DateTime(2024, 12, 31));

            projects.Add(new DashboardProject
            {
                AppUserId = userId,
                ProjectId = faker.Random.Number(10, 20),
                DateSubmitted = randomDate,
                DateCompleted = randomDate.AddDays(1),
                GithubUrl = "",
                IsCompleted = true
            }); 
        }

        return projects;
    }
}
