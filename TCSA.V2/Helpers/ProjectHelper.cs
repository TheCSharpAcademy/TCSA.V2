using TCSA.V2.Helpers.ProjectsSubHelpers;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class ProjectHelper
{
    public static List<Project> GetProjects()
    {
        var projects = new List<Project>();
        
        return projects
            .Concat(ConsoleProjectsHelper.GetProjects())
            .ToList();  
    }

    public static List<Project> GetProjectsInPortuguese()
    {
        var projects = new List<Project>();

        return projects
            .Concat(ConsoleProjectsHelper.GetProjectsInPortuguese())
            .ToList();
    }
}
