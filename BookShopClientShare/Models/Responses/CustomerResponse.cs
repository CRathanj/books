namespace BookShopClientShare.Models.Responses;

public class CustomerResponse
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Contact { get; set; } = default!;
    public string? Address { get; set; }
}
