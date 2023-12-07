using System.ComponentModel.DataAnnotations;
using BookShop.Contracts;

namespace BookShopAPI.Models.Requests
{
    public class CustomerCreateRequest : ICreateRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Contact { get; set; }
        public string Address { get; set; }

    }
}