using System.ComponentModel.DataAnnotations;
using BookShop.Contracts;

namespace BookShop.Models.Requests;
public class BookUpdateRequest : IUpdateRequest
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string ISBN { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Genres { get; set; }
    [Required]
    public string Author { get; set; }

    [Required]
    public DateTime PublishDate { get; set; }
    [Required]
    public Decimal Price { get; set; }
    public string? Description { get; set; } = default;
}