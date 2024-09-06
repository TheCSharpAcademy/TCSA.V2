namespace TCSA.V2.Models.Responses;

public class PaginatedList<T>
{
    public List<T> Items { get; }
    public int TotalItems { get; }
    public int PageNumber { get; }
    public readonly int PageSize = 5;
    public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);

    public PaginatedList(List<T> items, int totalItems, int pageNumber)
    {
        Items = items;
        TotalItems = totalItems;
        PageNumber = pageNumber;
    }

    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
}
