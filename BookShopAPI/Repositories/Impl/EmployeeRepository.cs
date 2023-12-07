using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories.Impl;

public class EmployeeRepository : IEmployeeRepository
{
    public readonly IDbContext _context;
    public EmployeeRepository(IDbContext context)
    {
        _context = context;
    }

    public bool Create(Employee entity)
    {
        try
        {
            _context.Employees.Add(entity);
            return _context.SaveChanges() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete > {ex.Message}");
        }
    }

    public bool Delete(Employee entity)
    {
       var found = GetQueryable().FirstOrDefault(x => x.Id == entity.Id);
        if (found != null)
        {
            try
            {
                _context.Employees.Remove(found);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete > {ex.Message}");
            }
        }
        return false;
    }

    public IQueryable<Employee> GetAll()
    {
         return _context.Employees.AsQueryable();
    }

    public Employee? GetById(string key)
    {
        return GetQueryable().FirstOrDefault(x => x.Id == key);
    }

    public Employee? GetById(string name, string contact)
    {
        return GetQueryable().FirstOrDefault(n => n.Name == name && n.Contact == contact);
    }

    public IQueryable<Employee> GetQueryable()
    {
        return _context.Employees.AsQueryable();
    }

    public bool Update(Employee entity)
    {
       _context.Employees.Update(entity);
        return _context.SaveChanges() > 0;
    }
}
