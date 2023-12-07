namespace BookShopClientShare.Models;
public class Customer
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Contact { get; set; } = default!;
    public string? Address { get; set; }
    public ICollection<Sale> Sales { get; set; } = default!;
}
