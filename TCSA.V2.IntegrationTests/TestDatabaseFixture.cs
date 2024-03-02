using Microsoft.EntityFrameworkCore;
using Moq;
using System.Net.Http;
using TCSA.V2.Data;
using TCSA.V2.Services;

namespace TCSA.V2.IntegrationTests;

public class TestDatabaseFixture : IClassFixture<TestDatabaseFixture>
{
    private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=TCSAV2-Test;Trusted_Connection=True";

    private static readonly object _lock = new();
    private static bool _databaseInitialized;
    private static bool _projectsInitialized;

    public Mock<IHttpClientFactory> MockHttpClientFactory { get; private set; }

    public TestDatabaseFixture()
    {
        MockHttpClientFactory = new Mock<IHttpClientFactory>();
        var fakeHttpClient = new HttpClient();
        MockHttpClientFactory.Setup(f => f.CreateClient(It.IsAny<string>())).Returns(fakeHttpClient);

        lock (_lock)
        {
            if (!_databaseInitialized)
            {
                using (var context = CreateContext())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    context.AddRange(
                        new ApplicationUser
                        {
                            Id="testId",
                            FirstName = "Pablo",
                            LastName = "Souza",
                            Email = "pablo.testerson@gmail.com",
                            UserName = "pablo.testerson@gmail.com",
                            Country = "Brazil",
                            DiscordAlias = "Bolotas"
                        });
                    context.SaveChanges();
                }

                _databaseInitialized = true;
            }

            if (!_projectsInitialized)
            {
                var factory = CreateDbContextFactory();

                var ProjectService = new ProjectService(factory);

                var projectService = new ProjectService(factory);

                projectService.PostArticle(new Models.DashboardProject
                {
                    AppUserId = "testId",
                    GithubUrl = "",
                    IsCompleted = false,
                    IsPendingNotification = false,
                    IsPendingReview = true,
                    ProjectId = 1,
                    DateSubmitted = DateTime.Now,
                }).Wait();

                _projectsInitialized = true;
            }
        }
    }

    public ApplicationDbContext CreateContext()
      => new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseSqlServer(ConnectionString)
              .Options);

    public class ApplicationDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext()
        {
            return new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(ConnectionString)
                .Options);
        }
    }

    public IDbContextFactory<ApplicationDbContext> CreateDbContextFactory()
    {
        return new ApplicationDbContextFactory();
    }
}
