using TCSA.V2.Models;
using TCSA.V2.Services;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace TCSA.V2.IntegrationTests;

public class ProjectServiceTests : IClassFixture<TestDatabaseFixture>
{
    private readonly TestDatabaseFixture _fixture;

    public ProjectServiceTests(TestDatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData("testId", 1, true)] 
    [InlineData("testId", 2, false)]  
    public async Task CheckIfProjectExistsReturnCorrectResult(string userId, int projectId, bool expectedResult)
    {
        var factory = _fixture.CreateDbContextFactory();
        var projectService = new ProjectService(_fixture.MockLogger.Object, factory);

        var actualResult = await projectService.IsProjectCompleted(userId, projectId);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public async Task PostArticleThatAlreadyExistsReturn0()
    {
        var factory = _fixture.CreateDbContextFactory();
        var projectService = new ProjectService(_fixture.MockLogger.Object, factory);

        var project = new DashboardProject
        {
            AppUserId = "testId",
            GithubUrl = "",
            IsCompleted = false,
            IsPendingNotification = false,
            IsPendingReview = true,
            ProjectId = 1,
            DateSubmitted = DateTime.Now,
        };

        var actualResult = await projectService.PostArticle(project);

        Assert.Equal(0, actualResult);
    }
}
