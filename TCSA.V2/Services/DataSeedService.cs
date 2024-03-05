using Bogus;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models.Forms;

namespace TCSA.V2.Services;

public interface IDataSeedService
{
    public Task SeedData(DataSeedForm form);
}

public class DataSeedService: IDataSeedService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public DataSeedService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task SeedData(DataSeedForm form)
    {
        var appUsers = GetAppUsersForSeedData(form.NumberOfUsers);

        using (var context = _factory.CreateDbContext())
        {
            try
            {
                await context.AspNetUsers.AddRangeAsync(appUsers);
                await context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    private List<ApplicationUser> GetAppUsersForSeedData(int quantity)
    {
        var users = new List<ApplicationUser>();

        for (int i = 0; i < quantity; i++)
        {
            var faker = new Faker("en");
            Guid newGuid = Guid.NewGuid();

            users.Add(new ApplicationUser
            {
                Id = newGuid.ToString(),
                FirstName = faker.Person.FirstName,
                LastName = faker.Person.LastName,
                Email = faker.Person.Email,
                Country = faker.Address.Country(),
                ExperiencePoints = faker.Random.Number(1, 100)
            });
        }

        return users;
    }
}
