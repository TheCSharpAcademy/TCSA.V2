using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TCSA.V2.Helpers
{
    public class EmbedCodeValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Embed code cant be empty");
            }

            var embedCode = value.ToString();
            string pattern = @"<iframe.*?src=""https:\/\/www\.youtube\.com\/embed\/[a-zA-Z0-9_-]+(\?.*?)?""[^>]*><\/iframe>";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(embedCode))
            {
                return new ValidationResult("The embed code is not a valid YouTube embed code.");
            }
                      
            return ValidationResult.Success;
        }
    }
}

