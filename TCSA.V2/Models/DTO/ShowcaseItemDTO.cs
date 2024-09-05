namespace TCSA.V2.Models.DTO;

public class ShowcaseItemDTO
{
    public string Id { get; set; }
    public string ApplicationUserId { get; set; }
    public int DashboardProjectId { get; set; }
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string Username { get; set; }
    public Area Area { get; set; }
    public string VideoUrl { get; set; }
}
