namespace BookShopClientShare.Models;

public class Employee 
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
    public string Position { get; set; } = default!;
    public decimal Salary { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Contact { get; set; } = default!;
    public DateTime HireDate { get; set; } = default!;
    public DateTime? StopDate { get; set; }
    public ICollection<Sale>? Sales { get; set; }
    public bool Active { get; set; }
}
