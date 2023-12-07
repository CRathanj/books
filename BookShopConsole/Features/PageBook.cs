using BookShopClientShare.Services;
using BookShopConsole.Models;
using BookShopClientShare;
using BookShopClientShare.Services;
namespace BookShopConsole.Features;

public class PageBook
{
    public static AppMenu DisplayMenu { get; set; } = new AppMenu()
    {
        Title = "Book",
        ChosenText = "Please input the options: ",
        Menus =
        [
            new(){ Text= "Viewing", Action = Viewing},
            new(){ Text= "Creating", Action = Creating},
            new(){ Text= "Updating", Action = Updating},
            new(){ Text= "Deleting", Action = Deleting},
            new(){ Text= "Back To Home", Action = Back}
        ]
    };
    private static void Back()
    {
        BookShopApplication
            .DisplayMenu
            .MenuSimulate(() =>
            {
                Console.Clear();
                Console.WriteLine();
            });
    } 


    private static void Viewing()
    {
        Task.Run(async () =>
        {
            BookService bookService = new BookService();
            Console.WriteLine("\n[Viewing Books]");
            var result = await bookService.GetAllBooks();
            var all = result?.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"Books: {count}");
            if (count == 0) return;

            Console.WriteLine($"{"Id",-36} {"ISBN",-20} {"Name",-30} {"Genres",-20} {"Author",-20} {"Price",-10} {"PublishDate",-15} {"Created",-15} {"LastUpdated",-15} ");
            Console.WriteLine(new string('=', 36 + 1 + 20 + 1 + 30 + 1 + 20 + 1 + 20 + 1 + 10 + 1 + 15 + 1 + 15 + 1 + 15));
            foreach (var bok in all)
            {
                Console.WriteLine($"{bok.Id,-36} {bok.ISBN,-20} {bok.Name,-30} {bok.Genres,-20} {bok.Author,-20} {bok.Price,-10:C} {bok.PublishDate,-15:d} {bok.CreatedOn,-15:d} {bok.LastUpdatedOn,-15:d} ");
            }
        }).Wait();
    }

    private static void Creating()
    {

    } 

    private static void Updating()
    {

    } 

    private static void Deleting()
    {

    } 
    
    public static void MenuHandler ()
    {
        PageBook
            .DisplayMenu
            .MenuSimulate(() =>
            {
                Console.WriteLine();
            });
    }
}