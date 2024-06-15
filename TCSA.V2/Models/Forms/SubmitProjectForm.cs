using System.ComponentModel.DataAnnotations;

namespace TCSA.V2.Models.Forms;

public class SubmitProjectForm
{
    public int ProjectId { get; set; }
    [Required]
    [GitHubUrl(ErrorMessage = "Invalid GitHub URL. Urls need to link to a valid pull request. They need to start with 'https://github.com/TheCSharpAcademy/CodeReviews'. Example: 'https://github.com/TheCSharpAcademy/CodeReviews.Console.MathGame/pull/42'. Please check how to submit pull requests by clicking on the link in the yellow box above.")]
    public string GithubUrl { get; set; }
}

public class GitHubUrlAttribute : ValidationAttribute
{
    private const string RequiredUrl = "https://github.com/TheCSharpAcademy/CodeReviews";

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var noValidationProjects = new int[] {22, 23, 75, 47, 48, 49, 50, 86};

        var project = (SubmitProjectForm)validationContext.ObjectInstance;

        if (noValidationProjects.Contains(project.ProjectId))
        {
            return ValidationResult.Success;
        }

        if (value is string githubUrl && !IsValidGitHubUrl(githubUrl))
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }

    private bool IsValidGitHubUrl(string url)
    {
        return url.StartsWith("https://github.com/TheCSharpAcademy/CodeReviews");
    }
}

