using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.DTO;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IGalleryService
{
    Task<IEnumerable<ShowcaseItem>> GetItems();
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

    public async Task<IEnumerable<ShowcaseItem>> GetItems()
    {
        using var context = _factory.CreateDbContext();
        try
        {
            return await context.ShowcaseItems
                .Include(x => x.ApplicationUser)
                .AsNoTracking()
                .OrderByDescending(i => i.GoldenProject)
                .ToListAsync();
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
            ProjectId = newItem.ProjectId,
            AppUserId = newItem.ApplicationUserId,
            VideoUrl = newItem.VideoUrl
        };

        try
        {
            using var context = _factory.CreateDbContext();
            await context.ShowcaseItems.AddAsync(showcaseItem);
            var result = await context.SaveChangesAsync();

            if (result == 0) // If no rows were affected
            {
                response.Status = ResponseStatus.Fail;
                response.Message = "Item could not be added (no changes made).";
            }
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
            var item = new ShowcaseItem { Id = itemToDelete.Id };
            context.ShowcaseItems.Remove(item);

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
