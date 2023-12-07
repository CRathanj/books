namespace BookShopClientShare.Models.Requests;

public class BookUpdateReqest
{
    public string Id { get; set; }

    public string ISBN { get; set; }

    public string Name { get; set; }

    public string Genres { get; set; }

    public string Author { get; set; }


    public DateTime PublishDate { get; set; }

    public string Price { get; set; }
    public string? Description { get; set; }
   

}
