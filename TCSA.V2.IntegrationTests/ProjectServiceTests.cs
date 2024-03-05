using TCSA.V2.Models;
using TCSA.V2.Services;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace TCSA.V2.IntegrationTests;

public class ProjectServiceTests : IClassFixture<TestDatabaseFixture>
{
    private readonly TestDatabaseFixture _fixture;

    public ProjectServiceTests (TestDatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData("testId", 1, true)]
    [InlineData("testId", 2, false)]
    public async Task CheckIfProjectExistsReturnCorrectResult (string userId, int projectId, bool expectedResult)
    {
        var factory = _fixture.CreateDbContextFactory();
        var projectService = new ProjectService(_fixture.MockLogger.Object, factory);

        var actualResult = await projectService.IsProjectCompleted(userId, projectId);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public async Task PostArticleThatAlreadyExistsReturn0 ()
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

    [Fact]
    public async Task GetCompletedProjectsById_ReturnsCorrectProjects ()
    {
        var userId = "testId";
        var expectedCompletedProjects = new List<int> { 1, 12, 13 };

        var projectService = new ProjectService(_fixture.MockLogger.Object, _fixture.CreateDbContextFactory());

        var actualCompletedProjects = await projectService.GetCompletedProjectsById(userId);

        Assert.NotNull(actualCompletedProjects);
        Assert.Equal(expectedCompletedProjects.OrderBy(x => x), actualCompletedProjects.OrderBy(x => x));
    }

    [Fact]
    public async Task AddNewProject_ReturnsCorrectIdAndUpdatesCompletedProjects ()
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
            ProjectId = 14,
            DateSubmitted = DateTime.Now,
        };

        var addedProjectId = await projectService.PostArticle(project);
        var completedProjectsAfterAddition = await projectService.GetCompletedProjectsById("testId");

        var expectedCompletedProjects = new List<int> { 1, 12, 13, 14 };
        Assert.Equal(expectedCompletedProjects.OrderBy(x => x), completedProjectsAfterAddition.OrderBy(x => x));
    }


}
