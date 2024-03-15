using TCSA.V2.Data;

namespace TCSA.V2.Models;

public class CommunityIssue
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? AppUserId { get; set; }
    public ApplicationUser? AppUser { get; set; }
    public int ProjectId { get; set; }
    public int CommunityProjectId { get; set; }
    public int ExperiencePoints { get; set; }   
    public IssueType Type { get; set; }
    public string GithubUrl { get; set; }
    public string IconUrl { get; set; }
    public bool IsClosed { get; set; }  
}


