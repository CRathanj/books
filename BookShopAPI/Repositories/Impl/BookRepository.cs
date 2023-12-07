using BookShop.Contracts;
using BookShop.Models;

namespace BookShop.Repositories.Impl;
public class BookRepository : IBookRepository
{
    private readonly IDbContext _context;
    public BookRepository(IDbContext context)
    {
        _context = context;
    }
    public bool Create(Book entity)
    {
        try
        {
            _context.Books.Add(entity);
            return _context.SaveChanges() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete > {ex.Message}");
        }
    }

    public bool Delete(Book entity)
    {
        var found = GetQueryable().FirstOrDefault(x => x.Id == entity.Id);
        if (found != null)
        {
            try
            {
                _context.Books.Remove(found);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete > {ex.Message}");
            }
        }
        return false;
    }

    public IQueryable<Book> GetAll()
    {
        return _context.Books.AsQueryable();
    }

    public Book? GetById(string key)
    {
        return GetQueryable().FirstOrDefault(x => x.Id == key);
    }

    public Book? GetByISBN(string isbn)
    {
        return GetQueryable().FirstOrDefault(x => x.ISBN == isbn);
    }

    public IQueryable<Book> GetQueryable()
    {
        return _context.Books.AsQueryable();
    }

    public bool Update(Book entity)
    {
       _context.Books.Update(entity);
        return _context.SaveChanges() > 0;
    }
}