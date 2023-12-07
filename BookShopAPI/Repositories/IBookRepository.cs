using BookShop.Contracts;
using BookShop.Models;

namespace BookShop.Repositories;

public interface IBookRepository : IRepository<Book, string>
{
    IQueryable<Book> GetQueryable();

    Book? GetByISBN(string isbn);
}
