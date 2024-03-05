using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class UserActivityHelper
{
    public static int GetXPs(ActivityType type, int projectId)
    {
        var issues = IssueHelper.GetIssues().Select(x => x.ProjectId).ToList();

        if (type == ActivityType.ProjectSubmitted || type == ActivityType.IssueSubmitted)
        {
            return 0;
        }

        if (type == ActivityType.IssueSubmitted || issues.Contains(projectId))
        {
            return IssueHelper.GetIssues().Single(x => x.Id == projectId).ExperiencePoints;
        }
        else if (type == ActivityType.ArticleRead)
        {
            return ArticleHelper.GetArticles().Single(x => x.Id == projectId).ExperiencePoints;
        }

        return ProjectHelper.GetProjects().Single(x => x.Id == projectId).ExperiencePoints;
    }

    public static string GetTitle(ActivityType type, int projectId)
    {
        var issues = IssueHelper.GetIssues().Select(x => x.ProjectId).ToList();

        if (type == ActivityType.IssueSubmitted || issues.Contains(projectId))
        {
            return $"The open source ticket <b>{IssueHelper.GetIssues().FirstOrDefault(x => x.Id == projectId)?.Description}</b> was marked as complete.";
        }

        return $"The project <b>{ProjectHelper.GetProjects().Single(x => x.Id == projectId).Title}</b> was marked as complete.";
    }

    public static string GetIcon(ActivityType type, int projectId)
    {
        if (type == ActivityType.IssueSubmitted)
        {
            return IssueHelper.GetIssues().Single(x => x.Id == projectId).IconUrl;
        }
        else if (type == ActivityType.ArticleRead)
        {
            return ArticleHelper.GetArticles().Single(x => x.Id == projectId).IconUrl;
        }

        return ProjectHelper.GetProjects().Single(x => x.Id == projectId).IconUrl;
    }

    public static string GetDescription(ActivityType type, int projectId)
    {
        switch (type)
        {
            case ActivityType.ArticleRead:
                return $"You read the article <b>{ArticleHelper.GetArticles().Single(x => x.Id == projectId).Title}</b>";
            case ActivityType.ProjectSubmitted:
                return $"You submitted the project <b>{ProjectHelper.GetProjects().Single(x => x.Id == projectId).Title}</b> for review.";
            case ActivityType.IssueSubmitted:
                return $"You submitted the issue <b>{IssueHelper.GetIssues().Single(x => x.Id == projectId).Description}</b> for review.";
            case ActivityType.ProjectCompleted:
                return GetTitle(type, projectId);
            case ActivityType.CodeReviewCompleted:
                return $"You've finished a code review for a <b>{ProjectHelper.GetProjects().Single(x => x.Id == projectId).Title}</b> project.";
            default:
                return "";
        }
    }

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
}
