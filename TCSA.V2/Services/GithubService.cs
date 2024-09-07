using Microsoft.EntityFrameworkCore;
using Octokit.Webhooks;
using Octokit.Webhooks.Events;
using Octokit.Webhooks.Events.Issues;
using Octokit.Webhooks.Events.PullRequest;
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


    protected override async Task ProcessIssuesWebhookAsync(WebhookHeaders headers, IssuesEvent issueEvent, IssuesAction issuesAction)
    {
        if (issuesAction != IssuesAction.Opened)
        {
            return;
        }

        var userName = issueEvent.Issue.User.Login;
        var user = new ApplicationUser();
        var reference = $"{headers.HookInstallationTargetId}-{issueEvent.Issue.Number}";

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
            IsClosed = false,
            Reference = reference
        };

        await _communityService.CreateIssue(communityIssue);
    }

    protected override async Task ProcessPullRequestWebhookAsync(WebhookHeaders headers, PullRequestEvent pullRequestEvent, PullRequestAction action)
    {
        if (action != PullRequestAction.Opened)
        {
            return;
        }

        var issue = new CommunityIssue();
        var user = new ApplicationUser();

        var userName = pullRequestEvent.PullRequest.User.Login;
        var reference = pullRequestEvent.PullRequest.Head.Ref;

        var issueId = reference.Split('-');
        var issueNumber = int.Parse(issueId[0]);
        var issueReference = $"{headers.HookInstallationTargetId}-{issueNumber}";

        using (var context = _factory.CreateDbContext())
        {
            issue = await context.Issues.FirstOrDefaultAsync(x => x.Reference == issueReference);
            user = await context.Users.FirstOrDefaultAsync(x => x.GithubUsername == userName);
        }

        var project = new DashboardProject
        {
            AppUserId = user.Id,
            GithubUrl = pullRequestEvent.PullRequest.Url,
            ProjectId = issue.ProjectId,
            IsPendingReview = true,
            DateSubmitted = DateTimeOffset.UtcNow,
        };

        var result = await _communityService.PostIssue(project, user.Id, isCommunityProject: true);
    }
}