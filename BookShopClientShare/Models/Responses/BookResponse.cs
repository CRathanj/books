namespace BookShopClientShare.Models.Responses
{
    public class BookResponse
    {
        public string Id { get; set; } = default!;
        public string ISBN { get; set; } = default!;
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string? Description { get; set; } = default;
        public string Author { get; set; } = default!;
        public string? Genres { get; set; } = default;
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public DateTime PublishDate { get; set; }
    }
}