using Microsoft.AspNetCore.Components;

namespace TCSA.V2.Models.DTO;

public class UserActivityAdminDisplay
{
    public string Date { get; set; }
    public string Time { get; set; }
    public MarkupString Description { get; set; }
    public string AppUserId { get; set; }
}
