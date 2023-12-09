using BookShop.Models;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Services
{
    public interface IReportService
    {
        Response<List<ReportResponse>> GetAllReports();
    }
}   