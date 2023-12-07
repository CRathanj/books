namespace BookShopConsole.Models
{
    public class MenuItem
    {
        public string Text { get; set; } = string.Empty;
        public Action Action { get; set; } = default!;
    }
}