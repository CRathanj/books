using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories;

public interface ISaleRepository :IRepository<Sale ,string>
{
    IQueryable<Sale> GetQueryable();
}
