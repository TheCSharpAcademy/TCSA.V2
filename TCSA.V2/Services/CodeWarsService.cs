using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using TCSA.V2.Data;
using TCSA.V2.Helpers.ProjectsSubHelpers;
using TCSA.V2.Models;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface ICodeWarsService
{
    Task<CodeWarsResponse> GetCodeWarsCompletedChallenges(string? username, List<CodeWarsChallenge> challenges);
    Task<int> MarkCodeWarsAsCompleted(int projectId, string userId, int currentPoints);
}
public class CodeWarsService : ICodeWarsService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly HttpClient _httpClient;

    public CodeWarsService(IDbContextFactory<ApplicationDbContext> factory, IHttpClientFactory httpClientFactory)
    {
        _factory = factory;
        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task<CodeWarsResponse> GetCodeWarsCompletedChallenges(string? username, List<CodeWarsChallenge> challenges)
    {
        var codeWarsResponse = new CodeWarsResponse();

        if (username == null)
        {
            codeWarsResponse.Status = ResponseStatus.Fail;
            codeWarsResponse.Message = "You haven't integrated your Codewars account yet. Go to the dashboard and click on 'Codewars Integration'";
            codeWarsResponse.Challenges = new List<CodeWarsChallenge>();
        }

        string apiUrl = $"https://www.codewars.com/api/v1/users/{username}/code-challenges/completed?";

        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            codeWarsResponse.Status = ResponseStatus.Fail;
            codeWarsResponse.Message = "Username not found. Go to the dashboard and click on 'Codewars Integration' to update your username.";
            codeWarsResponse.Challenges = new List<CodeWarsChallenge>();
            return codeWarsResponse;
        }

        string jsonResponse = await response.Content.ReadAsStringAsync();
        CodeWarsApiResponse apiResponse = JsonSerializer.Deserialize<CodeWarsApiResponse>(jsonResponse);

        var completedChallenges = apiResponse.data.Select(x => x.id).ToList();

        foreach (var challenge in challenges)
        {
            challenge.IsCompleted = completedChallenges.Contains(challenge.Id);
        }

        if (response.StatusCode == HttpStatusCode.OK)
        {
            codeWarsResponse.Status = ResponseStatus.Success;
            codeWarsResponse.Challenges = challenges;
        }

        return codeWarsResponse;
    }

    public async Task<int> MarkCodeWarsAsCompleted(int projectId, string userId, int currentPoints)
    {
        var project = SqlProjectsHelper.GetProjects().FirstOrDefault(x => x.Id == projectId);

        using (var context = _factory.CreateDbContext())
        {
            var dashboardProject = new DashboardProject
            {
                ProjectId = projectId,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                IsCompleted = true,
                IsPendingNotification = true,
                IsPendingReview = false,
                DateRequestedChange = DateTime.UtcNow,
                GithubUrl = "Not applicable"
            };

            context.DashboardProjects
                .Add(dashboardProject);

            context.UserActivity.Add(new AppUserActivity
            {
                ProjectId = projectId,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                ActivityType = ActivityType.ProjectCompleted
            });

            context.Users
                .Where(x => x.Id == userId)
                .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, project.ExperiencePoints + currentPoints));

            return await context.SaveChangesAsync();
        }
    }
}
