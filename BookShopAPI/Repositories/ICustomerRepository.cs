using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories;

public interface ICustomerRepository : IRepository<Customer, string>
{
    IQueryable<Customer> GetQueryable();
    Customer? GetByNameAndContact (string name,string contact);
}
