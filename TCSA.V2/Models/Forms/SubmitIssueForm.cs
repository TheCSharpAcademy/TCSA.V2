namespace TCSA.V2.Models.Forms;

public class SubmitIssueForm
{
    public string Title { get; set; }
    public int CommunityProjectId { get; set; }
    public IssueType Type { get; set; }
    public string GithubUrl { get; set; }
}


