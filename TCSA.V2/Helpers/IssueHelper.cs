using TCSA.V2.Helpers.ProjectsSubHelpers;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class IssueHelper
{
    public static List<Issue> GetIssues()
    {
        var issues = new List<Issue>();
        
        return issues
            .Concat(PointOfSaleIssuesHelper.GetIssues()) 
            .Concat(TCSAV2IssuesHelper.GetIssues())
            .ToList();  
    }
}
