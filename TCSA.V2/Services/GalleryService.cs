using TCSA.V2.Models;

namespace TCSA.V2.Services;

public class GalleryService
{

    public async Task<IEnumerable<ShowcaseItem>> GetItems()
    {

        return new List<ShowcaseItem>()
        {
            new ShowcaseItem()
            {
                Id = 1,
                Area=Area.React,
                ProjectName="Friends Manager"
            }
        };
    }
}
