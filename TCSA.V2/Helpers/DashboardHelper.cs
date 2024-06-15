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
}
