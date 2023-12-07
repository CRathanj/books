using BookShop.Contracts;

namespace BookShopAPI.Models.Responses;

public class CustomerResponse :IResponse
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Contact { get; set; } = default!;
    public string? Address { get; set; }
}
