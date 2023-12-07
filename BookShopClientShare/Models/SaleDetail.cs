namespace BookShopClientShare.Models; 
public class SaleDetail 
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public Sale Sale { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }