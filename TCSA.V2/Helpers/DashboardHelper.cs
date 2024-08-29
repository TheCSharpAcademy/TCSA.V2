using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class DashboardHelper
{
    public static bool CheckIfAreaIsCompleted(
        IEnumerable<Project> projects, 
        List<Article> articles, 
        List<int> completedProjects, 
        Area area, 
        Difficulty? difficulty)
    {
        if (difficulty != null)
        {
            var ids = projects
                .Where(x => x.Area == area && x.Difficulty == difficulty)
                .Select(x => x.Id)
                .ToList();

            foreach (int id in ids)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        if (area != Area.StartHere)
        {
            var projectIds = projects
                .Where(x => x.Area == area)
                .Select(x => x.Id);

            foreach (int id in projectIds)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
            }
        }
        else
        {
            var articleIds = articles
                .Where(x => x.Area == Area.StartHere)
                .Select(x => x.Id);

            foreach (int id in articleIds)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static List<Project> GetPendingProjects(
        IEnumerable<Project> projects,
        List<int> pendingProjects
    )
    {
        List<Project> pendingUserProjects = new();

        foreach (int projectId in pendingProjects)
        {
            Project project = projects.FirstOrDefault(x => x.Id == projectId);
            if (project != null)
            {
                pendingUserProjects.Add(project);
            }
        }
        return pendingUserProjects;
    }
    public static List<Project> GetCompletedProjects(
    IEnumerable<Project> projects,
    List<int> completedProjects
)
    {
        List<Project> completedUserProjects = new();

        foreach (int projectId in completedProjects)
        {
            Project project = projects.FirstOrDefault(x => x.Id == projectId);
            if (project != null)
            {
                completedUserProjects.Add(project);
            }
        }
        return completedUserProjects;
    }
}
