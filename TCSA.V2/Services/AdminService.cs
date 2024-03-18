﻿using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.Forms;

namespace TCSA.V2.Services;

public interface IAdminService
{
    Task ResetUserData(string userId);
    Task<List<ApplicationUser>> SearchUsers(SearchForm searchForm);
    Task<int> MarkProjectAsCompleted(int projectId, string userId, int currentPoints);
    Task<List<DashboardProject>> GetProjectsPendingReview();
    Task RequestChanges(int id);
    Task DeleteFromDashboard(int id);

}
public class AdminService : IAdminService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public AdminService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task DeleteFromDashboard(int id)
    {
        using (var context = _factory.CreateDbContext())
        {
            context.DashboardProjects
            .Remove(new DashboardProject { Id = id });

            await context.SaveChangesAsync();
        }
    }

    public async Task RequestChanges(int id)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.DashboardProjects
            .Where(x => x.Id == id)
                 .ExecuteUpdateAsync(y => y.SetProperty(u => u.DateRequestedChange, DateTime.UtcNow));

            await context.SaveChangesAsync();
        }
    }

    public async Task<List<DashboardProject>> GetProjectsPendingReview()
    {
        using (var context = _factory.CreateDbContext())
        {
            var peerReviews = context.UserReviews.ToList();

            var pendingReviewProjects = await context.DashboardProjects
            .Include(x => x.AppUser)
            .Where(x => x.IsPendingReview)
            .OrderBy(x => x.DateSubmitted)
            .ToListAsync();

            foreach (var prp in pendingReviewProjects)
            {
                if (peerReviews.Any(x => x.DashboardProjectId == prp.Id))
                {
                    Console.WriteLine($"{prp.ProjectId} matched!");

                    var reviewerId = "";
                    try
                    {
                        reviewerId = peerReviews.SingleOrDefault(x => x.DashboardProjectId == prp.Id).AppUserId;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    try
                    {
                        var reviewer = context.Users.SingleOrDefault(x => x.Id == reviewerId);

                        prp.Reviewer = $"{reviewer.FirstName} {reviewer.LastName}";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return await context.DashboardProjects
            .Include(x => x.AppUser)
            .Where(x => x.IsPendingReview)
            .OrderBy(x => x.DateSubmitted)
            .ToListAsync();
        }
    }

    public async Task<List<ApplicationUser>> SearchUsers(SearchForm searchForm)
    {
        using (var context = _factory.CreateDbContext())
        {
            IQueryable<ApplicationUser> query = context.Users.AsNoTracking();

            if (!string.IsNullOrEmpty(searchForm.Id))
            {
                query = query.Where(x => x.Id == searchForm.Id);
            }
            else if (!string.IsNullOrEmpty(searchForm.Email))
            {
                query = query.Where(x => x.Email == searchForm.Email);
            }
            else if (!string.IsNullOrEmpty(searchForm.DiscordAlias))
            {
                query = query.Where(x => x.DiscordAlias == searchForm.DiscordAlias);
            }
            else if (!string.IsNullOrEmpty(searchForm.Username))
            {
                query = query.Where(x => x.UserName == searchForm.Username);
            }
            else if (!string.IsNullOrEmpty(searchForm.FirstName) || !string.IsNullOrEmpty(searchForm.LastName))
            {
                query = query.Where(x => x.FirstName == searchForm.FirstName || x.LastName == searchForm.LastName);
            }
            else
            {
                return null;
            }

            var userIds = await query.Select(x => new ApplicationUser
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DiscordAlias = x.DiscordAlias,
                Email = x.Email,
                ExperiencePoints = x.ExperiencePoints,
                CreatedDate = x.CreatedDate,
                UserName = x.UserName,
            })
            .ToListAsync();

            return userIds;
        }
    }

    public async Task<int> MarkProjectAsCompleted(int projectId, string userId, int currentPoints)
    {
        var academyProject = new Article();

        using (var context = _factory.CreateDbContext())
        {
            if (ProjectHelper.GetProjects().Any(x => x.Id == projectId))
            {
                academyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == projectId);
            }
            else
            {
                var issue = context.Issues.FirstOrDefault(x => x.ProjectId == projectId);
                academyProject.ExperiencePoints = issue.ExperiencePoints;
            }

            var dashboardProject = await context.DashboardProjects.FirstOrDefaultAsync(x => x.ProjectId == projectId && x.AppUserId == userId);

            dashboardProject.IsPendingReview = false;
            dashboardProject.IsPendingNotification = true;
            dashboardProject.IsCompleted = true;
            dashboardProject.DateCompleted = DateTime.UtcNow;

            context.DashboardProjects
                .Update(dashboardProject);

            context.UserActivity.Add(new AppUserActivity
            {
                ProjectId = projectId,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                ActivityType = ActivityType.ProjectCompleted
            });

            context.Users
                .Where(x => x.Id == userId)
                .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentPoints));

            return await context.SaveChangesAsync();
        }
    }

    public async Task ResetUserData(string userId)
    {
        using (var context = _factory.CreateDbContext())
        {
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            if (!(user.FirstName == "Pablo" || user.LastName == "Academy" || user.LastName == "Test"))
            {
                return;
            }

            var projectsToDelete = context.DashboardProjects.Where(p => p.AppUserId == userId);
            context.DashboardProjects.RemoveRange(projectsToDelete);

            var activitiesToDelete = context.UserActivity.Where(p => p.AppUserId == userId);
            context.UserActivity.RemoveRange(activitiesToDelete);

            await context.Users
                .Where(x => x.Id == userId)
                .ExecuteUpdateAsync(y => y
                    .SetProperty(u => u.ExperiencePoints, 0)
                    .SetProperty(u => u.Level, Level.White)
                    .SetProperty(u => u.HasPendingBeltNotification, false)
                    .SetProperty(u => u.DiscordAlias, ""));

            await context.SaveChangesAsync();
        }
    }
}
