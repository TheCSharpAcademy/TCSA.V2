using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.DTO;

namespace TCSA.V2.Services;

public interface IGalleryService
{
    Task<IEnumerable<ShowcaseItem>> GetItems();
    Task AddItem(ShowcaseItemDTO newItem);
    Task DeleteItem(ShowcaseItem itemToDelete);
    Task UpdateItem(ShowcaseItem itemToUpdate);
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

    public async Task AddItem(ShowcaseItemDTO newItem)
    {
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
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async Task DeleteItem(ShowcaseItem itemToDelete)
    {
        using var context = _factory.CreateDbContext();
        context.ShowcaseItems.Remove(itemToDelete);
        await context.SaveChangesAsync();
    }

    public async Task UpdateItem(ShowcaseItem itemToUpdate)
    {
        using var context = _factory.CreateDbContext();
        context.ShowcaseItems.Update(itemToUpdate);
        await context.SaveChangesAsync();
    }

}
