using BookShopClientShare.Services;
using BookShopConsole.Models;
using BookShopClientShare;
using BookShopClientShare.Services;
using Spectre.Console;
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

            Table table = new();
            table.AddColumn(new TableColumn("Id").Width(36));
            table.AddColumn(new TableColumn("ISBN").Width(20));
            table.AddColumn(new TableColumn("Name").Width(30));
            table.AddColumn(new TableColumn("Genres").Width(20));
            table.AddColumn(new TableColumn("Author").Width(20));
            table.AddColumn(new TableColumn("Price").Width(10));
            table.AddColumn(new TableColumn("PublishDate").Width(15));
            table.AddColumn(new TableColumn("Created").Width(15));
            table.AddColumn(new TableColumn("LastUpdated").Width(15));

           
            foreach (var bok in all)
            {
                table.AddRow([
                    bok.Id, 
                    bok.ISBN, 
                    bok.Name, 
                    $"{bok.Genres}",
                    bok.Author,
                    $"{bok.Price:C}", 
                    $"{bok.PublishDate:d}",
                    $"{bok.CreatedOn:d}",
                    $"{bok.LastUpdatedOn:d}"
                ]);
             
            }
            AnsiConsole.Write(table);
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