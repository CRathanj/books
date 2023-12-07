using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories.Impl;

public class CustomerRepository : ICustomerRepository
{
    public readonly IDbContext _context;
    public CustomerRepository(IDbContext context)
    {
        _context = context;
    }

    public bool Create(Customer entity)
    {
        try
        {
            _context.Customers.Add(entity);
            return _context.SaveChanges() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete > {ex.Message}");
        }
    }

    public bool Delete(Customer entity)
    {
        var found = GetQueryable().FirstOrDefault(x => x.Id == entity.Id);
        if (found != null)
        {
            try
            {
                _context.Customers.Remove(found);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete > {ex.Message}");
            }
        }
        return false;
    }

    public IQueryable<Customer> GetAll()
    {
        return _context.Customers.AsQueryable();
    }

    public Customer? GetById(string key)
    {
        return GetQueryable().FirstOrDefault(x => x.Id == key);
    }

    public Customer? GetByNameAndContact(string name, string contact)
    {
        return GetQueryable().FirstOrDefault(n => n.Name == name && n.Contact == contact);
    }

    public IQueryable<Customer> GetQueryable()
    {
        return _context.Customers.AsQueryable();
    }

    public bool Update(Customer entity)
    {
        _context.Customers.Update(entity);
        return _context.SaveChanges() > 0;
    }
}
