using BookShop.Contracts;

namespace BookShopAPI.Models.Requests;

public class SaleCreateRequest : ICreateRequest
{
    public string CustomerId { get; set; }
    public string EmployeeId { get; set; }
    public List<SaleBookCreateRepuest> Books { get; set; }

}
