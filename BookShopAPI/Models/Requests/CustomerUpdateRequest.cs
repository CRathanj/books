using System.ComponentModel.DataAnnotations;
using BookShop.Contracts;

namespace BookShopAPI.Models.Requests;

public class CustomerUpdateRequest : IUpdateRequest
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Contact { get; set; }
    public string Address { get; set; }

}
