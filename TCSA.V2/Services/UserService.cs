using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.DTOs;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserById(string id);
    Task<AppUserForProfile> GetProfile(string id);
    Task<BaseResponse> UpdateProfile(AppUserForProfile user);
    Task<Level> GetUserLevel(string userId);
    Task<int> GetTodaysUserCount();
    Task UpdateBelt(string id, int level);
    Task<int> AddExperiencePoints(string id, int experiencePoints);
    Task ActivateAccount(string userId);
    Task<ApplicationUser> GetDetailedUserById(string id);
}

public class UserService : IUserService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<UserService> _logger;

    public UserService(ILogger<UserService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task ActivateAccount(string userId)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.Users
                 .Where(x => x.Id == userId)
                 .ExecuteUpdateAsync(y => y
                    .SetProperty(u => u.EmailConfirmed, true));

            await context.SaveChangesAsync();
        }
    }

    public async Task<int> AddExperiencePoints(string id, int experiencePoints)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.Users
                .Where(x => x.Id == id)
                .ExecuteUpdateAsync(y => y.SetProperty(u => u.ExperiencePoints, experiencePoints));

            return await context.SaveChangesAsync();
        }
    }

    public async Task UpdateBelt(string id, int level)
    {
        using (var context = _factory.CreateDbContext())
        {
            await context.Users
                 .Where(x => x.Id == id)
                 .ExecuteUpdateAsync(y => y
                    .SetProperty(u => u.Level, (Level)level)
                    .SetProperty(u => u.HasPendingBeltNotification, true));

            await context.SaveChangesAsync();
        }
    }

    public async Task<ApplicationUser> GetUserById(string id)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserById)}");
            return null;
        }
    }

    public async Task<ApplicationUser> GetDetailedUserById(string id)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.DashboardProjects)
                .Include(x => x.CodeReviewProjects)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserById)}");
            return null;
        }
    }

    public async Task<Level> GetUserLevel(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var result =  await context.AspNetUsers
                .Where(x => x.Equals(userId))
                .Select(x => new
                {
                    UserLevel = x.Level
                })
                .FirstOrDefaultAsync();

                return result.UserLevel;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserLevel)}");
            return Level.White;
        }
    }

    public async Task<BaseResponse> UpdateProfile(AppUserForProfile user)
    {
        var response = new BaseResponse
        {
            Status = ResponseStatus.Success,
            Message = "Profile updated successfully"
        };

        var updatedUser = new ApplicationUser();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                updatedUser = await context.Users
                     .Where(x => x.Id == user.Id)
                     .FirstOrDefaultAsync();

                updatedUser.CodeWarsUsername = user.CodeWarsUsername;
                updatedUser.DiscordAlias = user.DiscordAlias;
                updatedUser.GithubUsername = user.GithubUsername;
                updatedUser.LinkedInUrl = user.LinkedInUrl;
                updatedUser.Country = user.Country;
                updatedUser.DisplayName = user.DisplayName;

                if (!context.DashboardProjects.Any(x => x.ProjectId == 85 && x.AppUserId == user.Id)
                    && !string.IsNullOrEmpty(updatedUser.LinkedInUrl)
                    && !string.IsNullOrEmpty(updatedUser.GithubUsername)
                    && !string.IsNullOrEmpty(updatedUser.Country)
                    && !string.IsNullOrEmpty(updatedUser.DiscordAlias))
                {
                    await UpdateProfileProject(user, updatedUser.ExperiencePoints);
                }

                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            response.Status = ResponseStatus.Fail;
            response.Message = ex.Message;
            _logger.LogError(ex, $"Error in {nameof(UpdateProfile)}");
        }

        return response;
    }

    public async Task<AppUserForProfile> GetProfile(string id)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {

                var appUserForProfile = await context.Users
                    .Where(x => x.Id == id)
                    .Select(x => new AppUserForProfile
                    {
                        Id = x.Id,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        LinkedInUrl = x.LinkedInUrl,
                        CodeWarsUsername = x.CodeWarsUsername,
                        GithubUsername = x.GithubUsername,
                        DiscordAlias = x.DiscordAlias,
                        DisplayName = x.DisplayName,
                        Country = x.Country,
                    })
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (appUserForProfile == null)
                {
                    return null;
                }

                return appUserForProfile;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetProfile)}");
            return null;
        }
    }

    public async Task<int> GetTodaysUserCount()
    {
        var today = DateTimeOffset.Now.AddHours(-DateTime.Now.Hour);

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var td = await context.Users.Where(x => x.CreatedDate > today).ToListAsync();

                return await context.Users
                .CountAsync(x => x.CreatedDate > today);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserLevel)}");
            return 0;
        }
    }

    public async Task UpdateProfileProject(AppUserForProfile user, int currentPoints)
    {
        var project = ProjectHelper.GetProjects().Single(x => x.Id == 85);

        var dashboardProject = new DashboardProject
        {
            ProjectId = 85,
            AppUserId = user.Id,
            DateSubmitted = DateTime.UtcNow,
            IsCompleted = true,
            IsPendingNotification = true,
            IsPendingReview = false,
            DateRequestedChange = DateTime.UtcNow,
            GithubUrl = "Not applicable"
        };

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                await context.DashboardProjects
                            .AddAsync(dashboardProject);

                await context.UserActivity.AddAsync(new AppUserActivity
                {
                    ProjectId = 85,
                    AppUserId = user.Id,
                    DateSubmitted = DateTime.UtcNow,
                    ActivityType = ActivityType.ProjectCompleted
                });

                await context.Users
                    .Where(x => x.Id == user.Id)
                    .ExecuteUpdateAsync(y => y.SetProperty(u => u.ExperiencePoints, project.ExperiencePoints + currentPoints));

                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetUserLevel)}");
        }
    }
}
