using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface IUserActivityService
{
    Task PostUserActivity(AppUserActivity activity);
    Task<List<AppUserActivity>> GetActivityById(string userId);
    Task<List<AppUserActivity>> GetLatestActivity();
    Task<(int, int, int)> GetTodaysActivityCount();
}
public class UserActivityService : IUserActivityService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<UserActivityService> _logger;

    public UserActivityService(ILogger<UserActivityService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task PostUserActivity(AppUserActivity activity)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var alreadyExists = await context.UserActivity
                .AnyAsync(x => x.ProjectId == activity.ProjectId && x.AppUserId == activity.AppUserId);

                if (!alreadyExists)
                {
                    await context.UserActivity.AddAsync(activity);
                    var result = await context.SaveChangesAsync();

                    _logger.LogInformation($"{nameof(PostUserActivity)} executed correctly");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(PostUserActivity)}");
        }
    }

    public async Task<List<AppUserActivity>> GetActivityById(string id)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var activity = await context.UserActivity
                    .Where(x => x.AppUserId == id)
                    .OrderByDescending(x => x.DateSubmitted)
                    .ToListAsync();

                return activity ??= null;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetActivityById)}");
            return null;
        }
    }

    public async Task<List<AppUserActivity>> GetLatestActivity()
    {
        var thisWeek = DateTimeOffset.Now.AddDays(-3);

        try 
        {
            using (var context = _factory.CreateDbContext())
            {
                var activity = await context.UserActivity
                    .OrderByDescending(x => x.DateSubmitted)
                    .Where(x => x.DateSubmitted > thisWeek)
                    .ToListAsync();

                return activity ??= null;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetLatestActivity)}");
            return null;
        }
    }

    public async Task<(int, int, int)> GetTodaysActivityCount()
    {
        var today = DateTimeOffset.Now.AddHours(-DateTime.Now.Hour);

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var articles = await context.UserActivity.CountAsync(x => x.DateSubmitted > today && x.ActivityType == ActivityType.ArticleRead);

                var reviews = await context.UserActivity.CountAsync(x => x.DateSubmitted > today && x.ActivityType == ActivityType.ProjectSubmitted);

                var completed = await context.UserActivity.CountAsync(x => x.DateSubmitted > today && x.ActivityType == ActivityType.ProjectCompleted);

                return (articles, reviews, completed);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in {nameof(GetTodaysActivityCount)}");
            return (0,0,0);
        }
    }
}
