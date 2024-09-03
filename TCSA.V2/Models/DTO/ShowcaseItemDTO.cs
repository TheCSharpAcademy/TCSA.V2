namespace TCSA.V2.Models.DTO;

public class ShowcaseItemDTO
{
    public string ApplicationUserId { get; set; }
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string UserFirstName { get; set; }
    public string UserLastName { get; set; }
    public Area Area { get; set; }
    public string VideoUrl { get; set; }
}
