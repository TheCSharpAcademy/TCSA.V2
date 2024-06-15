using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class UserActivityHelper
{
    public static string GetRowStyle(ActivityType type)
    {
        return type switch
        {
            ActivityType.ProjectCompleted => "project-completed",
            ActivityType.ArticleRead => "article-read",
            ActivityType.ProjectSubmitted => "project-submitted",
            ActivityType.CodeReviewCompleted => "review-completed",
            ActivityType.IssueSubmitted => "issue-submitted"
        };
    }

    public static string GetDescription(List<int> issuesIds, AppUserActivity item, CommunityIssue? issue = null)
    {
        switch (item.ActivityType)
        {
            case ActivityType.ArticleRead:
                return $"You read the article <b>{ArticleHelper.GetArticles().Single(x => x.Id == item.ProjectId).Title}</b>";
            case ActivityType.ProjectSubmitted:
                return $"You submitted the project <b>{ProjectHelper.GetProjects().Single(x => x.Id == item.ProjectId).Title}</b> for review.";
            case ActivityType.IssueSubmitted:
                return $"You submitted the issue <b>{issue.Title}</b> for review.";
            case ActivityType.ProjectCompleted:
                return GetTitle(issuesIds, item, issue);
            case ActivityType.CodeReviewCompleted:
                return $"You've finished a code review for a <b>{ProjectHelper.GetProjects().Single(x => x.Id == item.ProjectId).Title}</b> project.";
            default:
                return "";
        }
    }

    public static string GetTitle(List<int> issuesIds, AppUserActivity item, CommunityIssue? issue = null)
    {
        if (issuesIds.Contains(item.ProjectId))
        {
            return $"The open source ticket <b>{issue.Title}</b> was marked as complete.";
        }

        return $"The project <b>{ProjectHelper.GetProjects().Single(x => x.Id == item.ProjectId).Title}</b> was marked as complete.";
    }
}
