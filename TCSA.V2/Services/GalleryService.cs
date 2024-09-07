using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Models;
using TCSA.V2.Models.DTO;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IGalleryService
{
    Task<List<ShowcaseItemDTO>> GetItems();
    Task<BaseResponse> AddItem(ShowcaseItemDTO newItem);
    Task<BaseResponse> DeleteItem(ShowcaseItemDTO itemToDelete);
}

public class GalleryService : IGalleryService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly ILogger<GalleryService> _logger;

    public GalleryService(ILogger<GalleryService> logger, IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
        _logger = logger;
    }

    public async Task<List<ShowcaseItemDTO>> GetItems()
    {
        using var context = _factory.CreateDbContext();
        try
        {
            var items = await context.ShowcaseItems
                .Include(x => x.ApplicationUser)
                .Include(x => x.DashboardProject)
                .AsNoTracking()
                .OrderByDescending(i => i.DateCreated)
                .ToListAsync();

            return items.Select(x => GalleryHelpers.ConvertToDTO(x)).ToList();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
            return null;
        }

    }

    public async Task<BaseResponse> AddItem(ShowcaseItemDTO newItem)
    {
        var response = new BaseResponse
        {
            Status = ResponseStatus.Success,
            Message = "Item added successfully"
        };

        var showcaseItem = new ShowcaseItem
        {
            DashboardProjectId = newItem.DashboardProjectId,
            AppUserId = newItem.ApplicationUserId,
            VideoUrl = newItem.VideoUrl,
            GithubUrl = newItem.GithubUrl,
        };

        try
        {
            using var context = _factory.CreateDbContext();
            await context.ShowcaseItems.AddAsync(showcaseItem);
            var result = await context.SaveChangesAsync();

            if (result == 0) 
            {
                response.Status = ResponseStatus.Fail;
                response.Message = "Item could not be added (no changes made).";
            }

            newItem.Id = showcaseItem.Id;
            response.Data = newItem;
        }
        catch (Exception ex)
        {
            response = new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = $"An error occurred while adding the item: {ex.Message}"
            };
        }

        return response;
    }

    public async Task<BaseResponse> DeleteItem(ShowcaseItemDTO itemToDelete)
    {
        var response = new BaseResponse
        {
            Status = ResponseStatus.Success,
            Message = "Project deleted successfully"
        };

        try
        {
            using var context = _factory.CreateDbContext();
            var showcaseItem = await context.ShowcaseItems.FirstOrDefaultAsync(x => x.Id == itemToDelete.Id);
            context.ShowcaseItems.Remove(showcaseItem);

            var result = await context.SaveChangesAsync();
            if (result == 0) 
            {
                response.Status = ResponseStatus.Fail;
                response.Message = "Project could not be deleted (not found or no changes).";
            }
        }
        catch (Exception ex)
        {
            response = new BaseResponse
            {
                Status = ResponseStatus.Fail, 
                Message = $"An error occurred while deleting the project: {ex.Message}"
            };
        }

        return response;
    }

}
