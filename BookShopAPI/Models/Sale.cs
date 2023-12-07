using BookShop.Contracts;

namespace BookShopAPI.Models
{
    public class Sale : IKey
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public IList<SaleDetail> SaleDetails { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
    }
}