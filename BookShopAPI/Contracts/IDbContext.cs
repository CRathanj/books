using BookShop.Models;
using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Contracts;

public interface IDbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Employee> Employees {get; set;}
    public DbSet<Sale> Sales {get; set;}
    public DbSet<SaleDetail> SaleDetails {get; set;}

    public int SaveChanges();
}