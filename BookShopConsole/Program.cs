
using BookShopConsole;

Console.WriteLine("Book Management");
BookShopApplication
    .DisplayMenu
    .MenuSimulate(() =>
    {
        Console.Clear();
        Console.WriteLine();
    });