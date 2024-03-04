using TCSA.V2.Data;

namespace TCSA.V2.Models.DTOs;

public class AppUserForLeaderboard
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? DisplayName { get; set; }
    public string Country { get; set; }
    public string LinkedInUrl { get; set; }
    public string GithubUsername { get; set; }
    public Level Level { get; set; }
    public int ExperiencePoints { get; set; }
    public int Ranking { get; set; }
}
