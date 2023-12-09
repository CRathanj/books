using BookShop.Models;

namespace BookShopAPI.Repositories;

public interface IReportRepository 
{
    List<Report> GetAll();
}
