using Newtonsoft.Json;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class BlogHelper
{
    public static List<Block> Convert(string content)
    {
        return JsonConvert.DeserializeObject<List<Block>>(content);
    }
}
