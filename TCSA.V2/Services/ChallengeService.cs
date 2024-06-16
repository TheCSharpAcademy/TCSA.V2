using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IChallengeService
{
    Task<List<Challenge>> GetChallenges();
    Task<Challenge> GetTodaysChallenge();
    Task<BaseResponse> CreateChallenge(Challenge challenge);
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

    public Task<List<Challenge>> GetChallenges()
    {
        throw new NotImplementedException();
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

}

