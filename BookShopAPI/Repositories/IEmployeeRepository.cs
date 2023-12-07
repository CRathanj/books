using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories;

public interface IEmployeeRepository : IRepository<Employee, string>
{
    IQueryable<Employee> GetQueryable();
    Employee? GetById (string name,string contact);
}
