using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TCSA.V2.Models;

namespace TCSA.V2.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<DashboardProject>? DashboardProjects { get; set; }
    public List<UserReview>? CodeReviewProjects { get; set; }
    public Level Level { get; set; }
    public int ExperiencePoints { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public string Country { get; set; }
    public bool HasPendingBeltNotification { get; set; }
    public bool HasUnreviewableProjectNotification { get; set; }
    public bool GithubLogin { get; set; }
    public string? DiscordAlias { get; set; }
    public string? CodeWarsUsername { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? GithubUsername { get; set; }
    public string? DisplayName { get; set; }
}

public enum Level
{
    White = 1,
    Green,
    [Display(Name = "Olive Green")]
    OliveGreen,
    Yellow,
    Orange,
    Red,
    Purple,
    Brown,
    Grey,
    Blue,
    Black
}


