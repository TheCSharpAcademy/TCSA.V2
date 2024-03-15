using Microsoft.AspNetCore.Components;

namespace TCSA.V2.Models.DTO;

public class UserActivityDisplay
{
    public ActivityType ActivityType { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Time { get; set; }
    public MarkupString Description { get; set; }
    public string AppUserId {  get; set; }
    public int ExperiencePoints { get; set; }
    public int CurrentExperiencePoints {  get; set; }
}
