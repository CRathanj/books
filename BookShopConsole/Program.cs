
using BookShopConsole;

Console.WriteLine("Book Management");
BookShopApplication
    .AppMenu
    .MenuSimulate(() =>
    {
        Console.Clear();
        Console.WriteLine();
    });