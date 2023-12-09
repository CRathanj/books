using BookShop.Repositories;
using BookShop.Repositories.Impl;
using BookShop.Services;
using BookShop.Services.Impl;
using BookShopAPI.Repositories;
using BookShopAPI.Repositories.Impl;
using BookShopAPI.Services;
using BookShopAPI.Services.Impl;

namespace BookShop.Configurations;
public static class DependencyInjection
{
    public static void AddDependencyInjection(this IServiceCollection services)
    {
        // Repositories
        services.AddTransient<IBookRepository, BookRepository>();
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        services.AddTransient<ISaleRepository, SaleRepository>();
        services.AddTransient<IReportRepository, ReportRepository>();
        
        // Services
        services.AddTransient<IBookService, BookService>();
        services.AddTransient<ICustomerService, CustomerService>();
        services.AddTransient<IEmployeeService, EmployeeService>();
        services.AddTransient<ISaleService, SaleService>();
        services.AddTransient<IReportService, ReportService>();
    }
}