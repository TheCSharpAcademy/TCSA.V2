using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TCSA.V2.Helpers;

public class GalleryVideoUrlValidator : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("URL cannot be empty.");
        }

        var url = value.ToString();

        string pattern = @"^(https:\/\/www\.youtube\.com\/watch\?v=)([a-zA-Z0-9_-]{11})$";
        Regex regex = new Regex(pattern);

        if (!regex.IsMatch(url))
        {
            return new ValidationResult("The URL is not a valid YouTube video link. Example of valid url:'https://www.youtube.com/watch?v=JJN5iZcUYtQ'");
        }

        return ValidationResult.Success;
    }
}
