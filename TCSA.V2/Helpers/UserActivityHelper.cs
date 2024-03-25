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
}
