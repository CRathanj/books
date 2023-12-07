using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories.Impl;

public class SaleRepository : ISaleRepository
{
    private readonly IDbContext _dbContext;
    public SaleRepository (IDbContext dbContext ) {
        _dbContext = dbContext;
    }
    public bool Create(Sale entity)
    {
        try
        {
            _dbContext.Sales.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete > {ex.Message}");
        } 
    }

    public bool Delete(Sale entity)
    {
        var found = GetQueryable().FirstOrDefault(x => x.Id == entity.Id);
        if (found != null)
        {
            try
            {
                _dbContext.Sales.Remove(found);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete > {ex.Message}");
            }
        }
        return false;
    }

    public IQueryable<Sale> GetAll()
    {
        return _dbContext.Sales.AsQueryable();
    }

    public Sale? GetById(string key)
    {
       return GetQueryable().FirstOrDefault(x => x.Id == key);
    }

    public IQueryable<Sale> GetQueryable()
    {
         return _dbContext.Sales.AsQueryable();
    }

    public bool Update(Sale entity)
    {
       _dbContext.Sales.Update(entity);
        return _dbContext.SaveChanges() > 0;
    }
}
