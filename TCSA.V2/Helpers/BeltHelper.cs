using TCSA.V2.Data;

namespace TCSA.V2.Helpers;

public static class BeltHelper
{
    public static List<string> GetBeltNotification (ApplicationUser user)
    {
        var projectsForNotification = new List<string>();

        var nextLevel = user.Level + 1;
        var projectsForNextLevel = ProjectHelper.GetProjects().Where(x => x.Level == nextLevel);
        var articlesForNextLevel = ArticleHelper.GetArticles().Where(x => x.Level == nextLevel);

        foreach (var project in projectsForNextLevel)
        {
            var projectToCheck = user.DashboardProjects?.FirstOrDefault(x => x.ProjectId == project.Id);
            if (projectToCheck == null || !projectToCheck.IsCompleted)
            {
                projectsForNotification.Add(project.Title);
            }
        }

        foreach (var article in articlesForNextLevel)
        {
            var projectToCheck = user.DashboardProjects?.FirstOrDefault(x => x.ProjectId == article.Id);
            if (projectToCheck == null || !projectToCheck.IsCompleted)
            {
                projectsForNotification.Add(article.Title);
            }
        }

        return projectsForNotification;
    }
}
