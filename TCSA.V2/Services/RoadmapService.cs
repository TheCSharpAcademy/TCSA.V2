using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;

namespace TCSA.V2.Services;

public interface IRoadmapService
{
    Task<Level> CalculateUserBelt(string userId);
}

public class RoadmapService : IRoadmapService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public RoadmapService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<Level> CalculateUserBelt(string userId)
    {
        var userProjects = new HashSet<int>();
        int userIssues = 0;
        int userReviews = 0;
        var level = Level.White;

        using (var context = _factory.CreateDbContext())
        {
            userProjects = new HashSet<int>(await context.DashboardProjects
            .Where(x => x.AppUserId == userId && x.IsCompleted)
            .Select(x => x.ProjectId)
            .ToListAsync());

            userIssues = await context.Issues.CountAsync(x => x.AppUserId == userId);
            userReviews = await context.UserReviews.CountAsync(x => x.AppUserId == userId);
        }

        if (userProjects.Count >= 6 && RoadmapHelper.GreenRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Green;
        }

        if (userProjects.Count >= 9 && RoadmapHelper.OliveGreenRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.OliveGreen;
        }

        if (userProjects.Count >= 13 && RoadmapHelper.YellowRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Yellow;
        }

        if (userProjects.Count >= 17 && RoadmapHelper.OrangeRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Orange;
        }

        if (level == Level.Orange
            && userIssues >= 1
            && userReviews >= 2
            && userProjects.Count >= 19
            && RoadmapHelper.RedRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Red;
        }

        int fullStackAreasCompleted = 0;

        foreach (var area in RoadmapHelper.FullStackAreas)
        {
            if (area.All(project => userProjects.Contains(project)))
            {
                fullStackAreasCompleted += 1;
            }
        }

        if (level == Level.Red
         && userIssues >= 2
         && userReviews >= 4
         && userProjects.Count >= 23
         && fullStackAreasCompleted >= 1)
        {
            level = Level.Purple;
        }

         if (level == Level.Purple
         && userIssues >= 4
         && userReviews >= 7
         && userProjects.Count >= 26
         && RoadmapHelper.AuthRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Brown;
        }

        var isFlagshipSubmitted = false;

        using (var context = _factory.CreateDbContext())
        {
            isFlagshipSubmitted = await context.DashboardProjects.AnyAsync(x => x.AppUserId == userId && x.ProjectId == 139);
        }

        if (level == Level.Brown
        && userIssues >= 7
        && userReviews >= 12
        && userProjects.Count >= 29
        && isFlagshipSubmitted
        && RoadmapHelper.SqlRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Grey;
        }

        if (level == Level.Grey
        && userIssues >= 10
        && userReviews >= 17
        && userProjects.Count >= 33
        && RoadmapHelper.AzureRequirements.All(project => userProjects.Contains(project)))
        {
            level = Level.Blue;
        }

        bool aspNetAreaCompleted = false;

        foreach (var area in RoadmapHelper.AspNetAreas)
        {
            if (area.All(project => userProjects.Contains(project)))
            {
                aspNetAreaCompleted = true;
            }
        }

        if (level == Level.Blue
        && userIssues >= 15
        && userReviews >= 25
        && userProjects.Count >= 37
        && fullStackAreasCompleted >= 2
        && aspNetAreaCompleted)
        {
            level = Level.Black;
        }

        return level;
    }
}
