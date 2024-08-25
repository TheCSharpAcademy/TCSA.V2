using Microsoft.EntityFrameworkCore;
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

        return new List<ShowcaseItem>()
        {
            new ShowcaseItem()
            {
                Id = Guid.NewGuid(),
                Area=Area.React,
                ProjectName="Friends Manager"
            }
        };
    }

    public async Task<ShowcaseItem> AddItem(ShowcaseItem newItem)
    {

        using (var context = _factory.CreateDbContext())
        {
            await context.ShowcaseItems.AddAsync(newItem);
            await context.SaveChangesAsync();
            return newItem;
        }
    }
}
