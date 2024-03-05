using System.ComponentModel.DataAnnotations;

namespace TCSA.V2.Models.DTOs;

public class AppUserForProfile
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [StringLength(20, ErrorMessage = "Discord alias cannot be longer than 20 characters.")]
    public string? DiscordAlias { get; set; }

    [StringLength(30, ErrorMessage = "CodeWars Username cannot be longer than 30 characters.")]
    public string? CodeWarsUsername { get; set; }

    [LinkedInUrlAttribute(ErrorMessage = "Submit a valid LinkedIn url")]
    public string? LinkedInUrl { get; set; }

    [StringLength(30, ErrorMessage = "GithubUsername cannot be longer than 30 characters.")]
    public string? GithubUsername { get; set; }

    [StringLength(20, ErrorMessage = "Display Name cannot be longer than 20 characters.")]
    public string? DisplayName { get; set; }
    public string? Country { get; set; }
}

public class LinkedInUrlAttribute : ValidationAttribute
{
    public override bool IsValid (object value)
    {
        if (value == null)
        {
            return true;
        }

        var url = value.ToString();

        return url.Contains("linkedin");
    }
}
