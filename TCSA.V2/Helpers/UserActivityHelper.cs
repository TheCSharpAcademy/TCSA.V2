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
