using Microsoft.EntityFrameworkCore;
using Octokit;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Services;

public class GalleryService
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
            return await context.ShowcaseItems.AsNoTracking().OrderBy(i=> i.GoldenProject).ToListAsync();
        }
        catch
        {
            return [];
        }

    }

    public async Task<ShowcaseItem> AddItem(ShowcaseItem newItem)
    {

        using var context = _factory.CreateDbContext();
        await context.ShowcaseItems.AddAsync(newItem);
        await context.SaveChangesAsync();
        return newItem;
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
