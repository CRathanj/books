using BookShop.Contracts;

namespace BookShopAPI.Models;

public class Member : IKey
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Contact { get; set; } = default!;
    public string Address { get; set; } = default!;
}

