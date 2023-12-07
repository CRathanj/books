using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShop.Models;
public class Book : IKey
{
    public string Id { get; set; } = default!;
    public string ISBN { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Author { get; set; } = default!;
    public decimal Price { get; set; }
    public string? Description { get; set; } = default;
    public Genres Genres { get; set; } = Genres.None;
    public DateTime? CreatedOn { get; set; }
    public DateTime? LastUpdatedOn { get; set; }
    public DateTime? PublishDate { get; set; }
    public IList<SaleDetail> SaleDetails { get; set; }
}