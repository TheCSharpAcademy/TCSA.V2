using TCSA.V2.Data;

namespace TCSA.V2.Models;

public class ShowcaseItem
{
    public int Id { get; set; }
    public ApplicationUser User { get; set; }
    public string AppUserId { get; set; }
    public int ProjectId { get; set; }
    public Area Area { get; set; }

    public bool GoldenProject { get; set; } = false;
    public string Link { get; set; }
    public int Likes { get; set; } = 0;
    public List<string> Comments { get; set; }
    public string AreaName
    {
        get
        {
            return nameof(Area);
        }
    }

    public string ProjectName { get; set; }

}

