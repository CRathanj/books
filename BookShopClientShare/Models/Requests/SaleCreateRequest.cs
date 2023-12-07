namespace BookShopClientShare.Models.Requests;
public class SaleCreateRequest
{
    public string CustomerId { get; set; }
    public string EmployeeId { get; set; }
    public List<SaleBookCreateRepuest> Books { get; set; }

}
