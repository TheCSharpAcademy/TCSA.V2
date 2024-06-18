using Microsoft.EntityFrameworkCore;
using TCSA.V2.Components.Dashboard.Pages;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IChallengeService
{
    Task<List<Challenge>> GetChallenges();
    Task<Challenge> GetTodaysChallenge();
    Task<List<int>> GetCompletedChallenges(string userId);
    Task<BaseResponse> CreateChallenge(Challenge challenge);
    Task<ApplicationUser> GetChallengeUser(string userId);
    Task CompleteChallenge(string userId, int challengeId);
    Task<Challenge> GetChallengeById(int challengeId);
    Task<DailyStreak> GetStreakInfo(string appUserId);
    Task<int> GetChallengesCount(string appUserId);
}

public class ChallengeService : IChallengeService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<ChallengeService> _logger;

    public ChallengeService(IDbContextFactory<ApplicationDbContext> factory, ILogger<ChallengeService> logger)
    {
        _factory = factory;
        _logger = logger;
    }

    public Task<Challenge> GetTodaysChallenge()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Challenge>> GetChallenges()
    {
        using (var context = _factory.CreateDbContext())
        {
            var currentUtcDate = DateTime.UtcNow;
            return await context.Challenges
                .Where(c => c.ReleaseDate < currentUtcDate)
                .OrderByDescending(c => c.ReleaseDate)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }

    public async Task CompleteChallenge(string userId, int challengeId)
    {
        using (var context = _factory.CreateDbContext())
        {

            var userChallenge = new UserChallenge
            {
                UserId = userId,
                ChallengeId = challengeId,
                CompletedAt = DateTime.UtcNow
            };

            context.UserChallenges.Add(userChallenge);
            await UpdateStreak(userId);
            await context.SaveChangesAsync();
        }
    }

    private async Task UpdateStreak(string userId)
    {
        using (var context = _factory.CreateDbContext())
        {

            var streak = await context.DailyStreaks.FirstOrDefaultAsync(s => s.AppUserId == userId);
            var today = DateTime.UtcNow.Date;

            if (streak == null)
            {
                streak = new DailyStreak
                {
                    AppUserId = userId,
                    CurrentStreak = 1,
                    LongestStreak = 1,
                    LastCompletedDate = today
                };
                context.DailyStreaks.Add(streak);
            }
            else
            {
                if (streak.LastCompletedDate == today.AddDays(-1))
                {
                    streak.CurrentStreak++;
                }
                else if (streak.LastCompletedDate < today.AddDays(-1))
                {
                    streak.CurrentStreak = 1;
                }

                if (streak.CurrentStreak > streak.LongestStreak)
                {
                    streak.LongestStreak = streak.CurrentStreak;
                }

                streak.LastCompletedDate = today;
                context.DailyStreaks.Update(streak);
            }

            await context.SaveChangesAsync();
        }
    }


    public async Task<BaseResponse> CreateChallenge(Challenge challenge)
    {
        var response = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                await context.Challenges.AddAsync(challenge).ConfigureAwait(false);
                await context.SaveChangesAsync().ConfigureAwait(false);

                _logger.LogInformation($"{nameof(CreateChallenge)} executed correctly");

                response.Status = ResponseStatus.Success;
                response.Message = "Challenge created successfully.";
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while creating challenge");

            response.Status = ResponseStatus.Fail;
            response.Message = $"Error occurred: {ex.Message}";
        }

        return response;
    }

    public async Task<List<int>> GetCompletedChallenges(string userId)
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.UserChallenges
                .Where(uc => uc.UserId == userId)
                .Select(uc => uc.ChallengeId)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }

    public async Task<ApplicationUser> GetChallengeUser(string userId)
    {
        using (var context = _factory.CreateDbContext())
        {
            var result = await context.AspNetUsers
                .Include(x => x.UserChallenges)
                .FirstOrDefaultAsync(x => x.Id.Equals(userId))
                .ConfigureAwait(false);

            return result;
        }
    }

    public async Task<Challenge> GetChallengeById(int challengeId)
    {
        using (var context = _factory.CreateDbContext())
        {
            var result = await context.Challenges   
                .FirstOrDefaultAsync(x => x.Id == challengeId)
                .ConfigureAwait(false);

            return result;
        }
    }

    public async Task<DailyStreak> GetStreakInfo(string appUserId)
    {
        using (var context = _factory.CreateDbContext())
        {
            var streakInfo = await context.DailyStreaks
                .FirstOrDefaultAsync(x => x.AppUserId == appUserId)
                .ConfigureAwait(false);

            return streakInfo ?? new DailyStreak();
        }
    }

    public async Task<int> GetChallengesCount(string appUserId)
    {
        var count = 0;

        using (var context = _factory.CreateDbContext())
        {
            count = await context.UserChallenges
                .Where(x => x.UserId == appUserId)
                .CountAsync()
                .ConfigureAwait(false);

            return count;
        }
    }
}