using TCSA.V2.Services;

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
        var projectService = new ProjectService(factory);

        var actualResult = await projectService.IsProjectCompleted(userId, projectId);

        Assert.Equal(expectedResult, actualResult);
    }
}
