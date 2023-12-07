using BookShopConsole.Models;
namespace BookShopConsole.Features;

public class PageReport
{
    public static AppMenu DisplayMenu { get; set; } = new AppMenu()
    {
        Title = "Report",
        ChosenText = "Please input the options: ",
        Menus =
        [
            new(){ Text= "Viewing", Action = Viewing},
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

    } 
    
    public static void MenuHandler ()
    {
        PageReport
            .DisplayMenu
            .MenuSimulate(() =>
            {
                Console.WriteLine();
            });
    }
}