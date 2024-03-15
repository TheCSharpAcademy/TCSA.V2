namespace TCSA.V2.Models;

public class Issue : Article
{
    public int ProjectId { get; set; }
    public int CommunityProjectId { get; set; }
    public string AppUserId { get; set; }
    public string Description { get; set; }
    public IssueType Type { get; set; }
    public string GithubUrl { get; set; }
    public string ProjectGithubUrl { get; set; }
}

public enum IssueType
{
    Bugfix,
    Feature,
    Infrastructure,
    Translation
}
