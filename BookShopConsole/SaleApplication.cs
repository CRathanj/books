using BookShopConsole.Models;

namespace BookShopConsole
{
    public class SaleApplication
    {
        public static string BaseUrl { get; set; } = "http://localhost:5238";
        public static SaleMenu AppMenu { get; set; } = new SaleMenu()
        {
           
        };
    }
}