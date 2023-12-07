using BookShop.Contracts;
using BookShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Configurations;

public static class DbContextConfiguration
{
    public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IDbContext, BookShopDbContext>(options => {
            options.UseMySql(
                configuration.GetConnectionString("Default"), 
                ServerVersion.Parse(configuration.GetConnectionString("ServerVersion"))
            );
        });
    }
}