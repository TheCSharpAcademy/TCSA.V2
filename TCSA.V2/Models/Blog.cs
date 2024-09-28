using TCSA.V2.Data;

namespace TCSA.V2.Models;

public class Blog
{
    public int Id { get; set; }
    public DateTimeOffset PublishedDate { get; set; }
    public string Title { get; set; }
    public string CardImgUrl { get; set; }
    public string Content { get; set; }    
    public ApplicationUser ApplicationUser { get; set; }
    public string AppUserId { get; set; }
    public bool IsPublished { get; set; } = false;
    public string Description { get; set; }
}
