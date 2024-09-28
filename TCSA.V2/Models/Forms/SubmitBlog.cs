using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TCSA.V2.Models.Forms; 

public class SubmitBlog
{
    [Required]
    [StringLength(100, ErrorMessage = "The Title cannot be longer than 50 characters.")]
    public string Title { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "The Description cannot be longer than 200 characters.")]
    public string Description { get; set; }

    [Required]
    [Url]
    [ValidImageUrl(ErrorMessage = "Invalid ImgUrl. The URL must start with http:// or https:// and end with .jpg or .png.")]
    public string ImgUrl { get; set; }

    [Required]
    [StringLength(2000, ErrorMessage = "The Body cannot be longer than 2000 characters.")]
    public string Body { get; set; }
}

// Custom Validation Attribute for ImgUrl
public class ValidImageUrlAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var url = value as string;

        if (url == null)
            return new ValidationResult("URL is required.");

        // Regex to validate URL pattern
        string pattern = @"^(http(s)?:\/\/).*\.(jpg|png)$";
        if (Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase))
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(ErrorMessage ?? "Invalid image URL format.");
        }
    }
}
