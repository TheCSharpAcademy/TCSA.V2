using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;

namespace TCSA.V2.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserById(string id);
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
}
