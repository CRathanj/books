using BookShop.Contracts;

namespace BookShopAPI.Models.Responses
{
    public class ReportResponse : IResponse
    {
        public string Id { get; set; } = default!;
        public string CusId { get; set; } = default!;
        public string EmpId { get; set; } = default!;
        public Decimal Amount { get; set; } = default!;
        public DateTime Date { get; set; } = default!;
    }
}