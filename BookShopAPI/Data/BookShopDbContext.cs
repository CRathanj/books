using BookShop.Contracts;
using BookShop.Data.Entities;
using BookShop.Models;
using BookShopAPI.Data.Entities;
using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BookShop.Data;

public class BookShopDbContext : DbContext, IDbContext
{
    public BookShopDbContext(DbContextOptions<BookShopDbContext> options) : base(options)
    { }
    public DbSet<Book> Books { get; set; } = default!;
    public DbSet<Customer> Customers { get; set; } = default!;
    public DbSet<Employee> Employees { get; set; } = default!;
    public DbSet<Sale> Sales { get; set; } = default!;
    public DbSet<SaleDetail> SaleDetails { get; set; } = default!;
    public IDbConnection Connection => Database.GetDbConnection();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SaleEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SaleDetailEntityTypeConfiguration());

    }
}