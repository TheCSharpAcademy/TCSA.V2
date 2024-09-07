using System.ComponentModel.DataAnnotations;
using TCSA.V2.Helpers;

namespace TCSA.V2.Models.Forms;

public class SubmitShowCaseItemForm
{
    [Required]
    public int ProjectId { get; set; }

    [VideoUrl(ErrorMessage = "Invalid VideoUrl. Urls need to link to a YouTube link. Example: 'https://www.youtube.com/watch?v=fQ9RFR1KTbY'")]
    [Required]  
    public string VideoUrl { get; set; }

    [ShowcaseGitHubUrl(ErrorMessage = "Invalid GitHub URL. Urls need to link to a valid Github repository. The format should be 'https://github.com/RepositoryName'.")]
    [Required]
    public string GithubUrl { get; set; }
}

public class ShowcaseGitHubUrlAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string githubUrl && !IsValidGitHubUrl(githubUrl))
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }

    private bool IsValidGitHubUrl(string url)
    {
        return url.StartsWith("https://github.com/");
    }
}

public class VideoUrlAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string githubUrl && !GalleryHelpers.YouTubeUrlValidator(githubUrl))
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
