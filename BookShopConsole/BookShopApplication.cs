using BookShopClientShare;
using BookShopClientShare.Services;
using BookShopConsole.Models;

namespace BookShopConsole;

public class BookShopApplication
{
    public static string BaseUrl { get; set; } = "http://localhost:5238";


    public static AppMenu AppMenu { get; set; } = new AppMenu()
    {
        Title = "Book",
        ChosenText = "Please input the options: ",
        Menus =
        [
            new(){ Text= "Viewing", Action=ViewingProducts},
            new(){ Text= "Creating", Action=CreatingProducts},
            new(){ Text= "Updating", Action=UpdatingProducts},
            new(){ Text= "Deleting", Action=DeletingProducts},
            new(){ Text= "Exiting", Action = ExitingProgram}
        ]

    };
    public static void ExitingProgram()
    {
        Console.WriteLine("\n[Exiting Program]");
        Environment.Exit(0);
    }
    private static void DeletingProducts()
    {
        //     Task.Run(async () =>
        //     {
        //         RestClient<Product> restClient = new(BaseUrl);
        //         Console.WriteLine("\n[Deleting Product]");
        //         while (true)
        //         {
        //             Console.Write("Product Id/Code: ");
        //             var key = Console.ReadLine() ?? "";
        //             var endpoint = $"api/products/{key}";
        //             var result = await restClient.DeleteAsync<Result<string>>(endpoint);
        //             if (result!.Data != null)
        //             {
        //                 Console.WriteLine($"Successfully delete the product with id/code, {key}");
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"Failed to delete a product with id/code, {key}");
        //             }

        //             if (WaitForEscPressed("ESC to stop or any key for more deleting ..."))
        //             {
        //                 break;
        //             }
        //         }
        //     }).Wait();
    }
    private static void UpdatingProducts()
    {
        //     Task.Run(async () =>
        //     {
        //         RestClient<Product> restClient = new(BaseUrl);
        //         Console.WriteLine("\n[Updating Products]");
        //         while (true)
        //         {
        //             Console.Write("Product Id/Code(required): ");
        //             var key = Console.ReadLine() ?? "";
        //             var endpoint = "api/products";
        //             Console.Write("New Name (optional)  : ");
        //             var name = Console.ReadLine();

        //             Console.WriteLine($"Category available: {Enum.GetNames<Category>().Aggregate((a, b) => a + ", " + b)}");
        //             Console.Write("New Category: ");
        //             var category = Console.ReadLine();

        //             var result = await restClient.PutAsync<ProductUpdateReq, Result<string>>(endpoint, new ProductUpdateReq()
        //             {
        //                 Key = key,
        //                 Name = name,
        //                 Category = category
        //             });

        //             if (result!.Data != null)
        //             {
        //                 Console.WriteLine($"Successfully update the product with id/code, {key}");
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"Failed to update the product with id/code, {key}");
        //             }

        //             Console.WriteLine();
        //             if (WaitForEscPressed("ESC to stop or any key for more updating...")) break;
        //         }
        //     }).Wait();
    }
    private static bool WaitForEscPressed(string text)
    {
        Console.Write(text);
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Console.WriteLine(keyInfo.KeyChar);
        return keyInfo.Key == ConsoleKey.Escape;
    }
    private static void CreatingProducts()
    {
        //     Task.Run(async () =>
        //     {
        //         RestClient<Product> restClient = new(BaseUrl);
        //         Console.WriteLine("\n[Creating Product]");
        //         var endpoint = "api/products";
        //         while (true)
        //         {
        //             var req = GetCreateProduct();
        //             if (req != null)
        //             {
        //                 var result = await restClient.PostAsync<ProductCreateReq, Result<string>>(endpoint, req);
        //                 var id = result!.Data;
        //                 if (!string.IsNullOrEmpty(id))
        //                     Console.WriteLine($"Successfully created a new product with id, {id}");
        //                 else
        //                     Console.WriteLine($"Failed to create a new product code, {req.Code}");
        //             }

        //             Console.WriteLine();
        //             if (WaitForEscPressed("ESC to stop or any key for more creating...")) break;
        //         }
        //     }).Wait();
    }
    // static ProductCreateReq? GetCreateProduct()
    // {
    //     Console.WriteLine($"Category available: {Enum.GetNames<Category>().Aggregate((a, b) => a + ", " + b)}");
    //     Console.Write("Product(code/name/category): ");
    //     string data = Console.ReadLine() ?? "";
    //     var dataParts = data.Split("/");
    //     if (dataParts.Length < 3)
    //     {
    //         Console.WriteLine("Invalid create product's data");
    //         return null;
    //     }
    //     var code = dataParts[0].Trim();
    //     var name = dataParts[1].Trim();
    //     var category = dataParts[2].Trim();

    //     return new ProductCreateReq() { Code = code, Name = name, Category = category };

    // }
    private static void ViewingProducts()
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
}
