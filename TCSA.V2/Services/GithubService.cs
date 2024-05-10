using Microsoft.EntityFrameworkCore;
using Octokit.Webhooks;
using Octokit.Webhooks.Events;
using Octokit.Webhooks.Events.Issues;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Services;

namespace TCSA.V2.Controllers;

public sealed class MyWebhookEventProcessor : WebhookEventProcessor
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ICommunityService _communityService;


    public MyWebhookEventProcessor(IDbContextFactory<ApplicationDbContext> factory, ICommunityService communityService)
    {
        _factory = factory;
        _communityService = communityService;
    }


    protected override async Task ProcessIssuesWebhookAsync(WebhookHeaders headers, IssuesEvent issueEvent,  IssuesAction issuesAction)
    {
        var userName = issueEvent.Issue.User.Login;
        var user = new ApplicationUser();

        using (var context = _factory.CreateDbContext())
        {
            user = await context.Users.FirstOrDefaultAsync(x => x.GithubUsername == userName);
        }

        var splitTitle = issueEvent.Issue.Title.Split('/');

        IssueType type = splitTitle[0] switch 
        {
            "bugfix" => IssueType.Bugfix,
            "feature" => IssueType.Feature,
            "translation" => IssueType.Translation,
            _ => IssueType.Feature
        };  

        var communityIssue = new CommunityIssue
        {
            Title = string.IsNullOrEmpty(splitTitle[1]) ? issueEvent.Issue.Title : splitTitle[1],
            AppUserId = user.Id,
            GithubUrl = issueEvent.Issue.Url,
            CommunityProjectId = 87,
            Type = type,
            IconUrl = "",
            ExperiencePoints = 20,
            IsClosed = false
        };

        await _communityService.CreateIssue(communityIssue);
    }
}