using BookShop.Models;
using BookShop.Models.Requests;
using BookShop.Models.Responses;
using BookShopAPI.Models;

namespace BookShopAPI.Extensions;

public static class BookExtensions
{
    public static BookResponse ToResponse(this Book bok)
    {
        return new BookResponse
        {
            Id = bok.Id,
            ISBN = bok.ISBN,
            Name = bok.Name,
            Genres = Enum.GetName<Genres>(bok.Genres),
            Price = bok.Price,
            Description = bok.Description,
            Author = bok.Author,
            CreatedOn = bok.CreatedOn,
            PublishDate=bok.PublishDate,
            LastUpdatedOn = bok.LastUpdatedOn
        };
    }
    public static Book ToEntity(this BookCreateRequest req)
    {
        var genres = Genres.None;
        Genres.TryParse(req.Genres, out genres);
        return new Book()
        {
            Id = Guid.NewGuid().ToString(),
            ISBN = req.ISBN,
            Name = req.Name,
            Author = req.Author,
            Price = req.Price,
            Description = req.Description,
            Genres = genres,
            CreatedOn = null,
            PublishDate=req.PublishDate,
            LastUpdatedOn = null
        };
    }
    public static void Copy(this Book bok, BookUpdateRequest req)
    {
        var genres = Genres.None;
        Genres.TryParse(req.Genres, out genres);
        bok.Name = req.Name;
        bok.Genres = genres;
        bok.Author = req.Author;
        bok.ISBN = req.ISBN;
        bok.PublishDate = req.PublishDate;
        bok.Price = req.Price;
        bok.Description = req.Description;
    }
    public static Book Clone(this Book bok)
    {
        return new Book()
        {
            Id = bok.Id,
            ISBN = bok.ISBN,
            Name = bok.Name,
            Author = bok.Author,
            Price = bok.Price,
            Description = bok.Description,
            Genres = bok.Genres,
            CreatedOn = bok.CreatedOn,
            LastUpdatedOn = bok.LastUpdatedOn,
            PublishDate = bok.PublishDate,
        };
    }
    public static void Copy(this Book bok, Book other)
    {
        bok.Id = other.Id;
        bok.ISBN = other.ISBN;
        bok.Name = other.Name;
        bok.Author = other.Author;
        bok.Price = other.Price;
        bok.Description = other.Description;
        bok.Genres = other.Genres;
        bok.CreatedOn = other.CreatedOn;
        bok.LastUpdatedOn = other.LastUpdatedOn;
        bok.PublishDate = other.PublishDate;
    }
}
