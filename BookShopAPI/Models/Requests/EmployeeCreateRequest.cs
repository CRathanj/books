using System.ComponentModel.DataAnnotations;
using BookShop.Contracts;

namespace BookShopAPI.Models.Requests
{
    public class EmployeeCreateRequest : ICreateRequest
    {
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string Gender { get; set; } = default!;
        [Required]
        public string Position { get; set; } = default!;
        [Required]
        public Decimal Salary { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string Contact { get; set; } = default!;
        public DateTime HireDate { get; set; } = default!;
        public DateTime? StopDate { get; set; }
        public bool Active { get; set; }
    }

}