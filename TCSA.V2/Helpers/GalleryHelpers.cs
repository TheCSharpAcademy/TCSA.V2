using System.Text.RegularExpressions;
using TCSA.V2.Models.DTO;
using TCSA.V2.Models;
using TCSA.V2.Data;

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

    public static ShowcaseItemDTO ConvertToDTO(ShowcaseItem item)
    {
        var projectsHelper = ProjectHelper.GetProjectInfos().AsQueryable();

        return new ShowcaseItemDTO
        {
            Id = item.Id,
            ApplicationUserId = item.AppUserId,
            ProjectId = item.DashboardProject?.ProjectId ?? 0,
            DashboardProjectId = item.DashboardProject?.Id ?? 0,
            Username = string.IsNullOrEmpty(item.ApplicationUser?.FirstName)
                ? item.ApplicationUser?.UserName
                : $"{item.ApplicationUser.FirstName} {item.ApplicationUser.LastName}",
            Area = projectsHelper.FirstOrDefault(p => p.Id == item.DashboardProject.ProjectId).Area,
            VideoUrl = item.VideoUrl,
            ProjectName = projectsHelper.FirstOrDefault(p => p.Id == item.DashboardProject.ProjectId).Title
        };
    }

    public static ShowcaseItem ConvertToModel(ShowcaseItemDTO dto, IEnumerable<DashboardProject> projects, IEnumerable<ApplicationUser> users)
    {
        return new ShowcaseItem
        {
            Id = dto.Id,
            AppUserId = dto.ApplicationUserId,
            DateCreated = DateTime.Now,
            VideoUrl = dto.VideoUrl
        };
    }
}
