using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public interface IUserActivityService
{
    Task PostUserActivity(AppUserActivity activity);
    Task<List<AppUserActivity>> GetActivityById(string userId);
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
}
