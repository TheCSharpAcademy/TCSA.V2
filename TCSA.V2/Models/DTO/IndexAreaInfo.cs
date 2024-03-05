namespace TCSA.V2.Models;

public class IndexAreaInfo
{
    public Area Area { get; set; }
    public string Description { get; set; }
    public string TitleImgUrl { get; set; }

    public List<Project> Projects { get; set; }
}
