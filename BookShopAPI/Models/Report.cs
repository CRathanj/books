using BookShop.Contracts;

namespace BookShopAPI.Models
{
    public class Report : IKey
    {
        public string Id { get; set; } = default!;
        public string CusId { get; set; } = default!;
        public string EmpId { get; set; } = default!;
        public Decimal Amount { get; set; } = default!;
        public DateTime Date { get; set; } = default!;
    }
}