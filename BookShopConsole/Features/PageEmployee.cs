using BookShopConsole.Models;
namespace BookShopConsole.Features;

public class PageEmployee
{
    public static AppMenu DisplayMenu { get; set; } = new AppMenu()
    {
        Title = "Employee",
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
        PageEmployee
            .DisplayMenu
            .MenuSimulate(() =>
            {
                Console.WriteLine();
            });
    }
}