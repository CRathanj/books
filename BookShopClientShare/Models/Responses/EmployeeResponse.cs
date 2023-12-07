namespace BookShopClientShare.Models.Responses
{
    public class EmployeeResponse
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Gender { get; set; } = default!;
        public string Position { get; set; } = default!;
        public Decimal Salary { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Contact { get; set; } = default!;
        public DateTime HireDate { get; set; } = default!;
        public DateTime? StopDate { get; set; } = default!;
        public bool Active { get; set; }
    }
}
