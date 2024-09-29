using Newtonsoft.Json;
using System.Text.RegularExpressions;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class BlogHelper
{
    public static string ConvertToJson(string content)
    {
        return "";
    }

    public static List<Block> ConvertFromJson(string content)
    {
        return JsonConvert.DeserializeObject<List<Block>>(content);
    }

    public static string GetSlug(string title)
    {
        title = title.ToLower();
        title = title.Replace(" ", "-");
        title = Regex.Replace(title, @"[^a-z0-9-]", "");
        return title;
    }
}
