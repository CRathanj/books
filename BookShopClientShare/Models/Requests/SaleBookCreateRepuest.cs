namespace BookShopClientShare.Models.Requests;

public class SaleBookCreateRepuest
{
    public string BookId { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
}
