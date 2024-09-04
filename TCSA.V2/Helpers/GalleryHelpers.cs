using System.Text.RegularExpressions;

namespace TCSA.V2.Helpers;

public class GalleryHelpers
{
    public static string GalleryVideoUrlFormatter(string url)
    {
        return url.Replace("watch?v=", "embed/");
    }

    public static bool YouTubeUrlValidator(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        string pattern = @"^(https:\/\/www\.youtube\.com\/watch\?v=)([a-zA-Z0-9_-]{11})$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }
}
