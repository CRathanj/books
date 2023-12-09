using BookShop.Models;
using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BookShop.Contracts;

public interface IDbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Employee> Employees {get; set;}
    public DbSet<Sale> Sales {get; set;}
    public DbSet<SaleDetail> SaleDetails {get; set;}
    public IDbConnection Connection { get; }

    public int SaveChanges();
}