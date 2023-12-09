using BookShop.Models;
using BookShopAPI.Models.Responses;
using BookShopAPI.Repositories;
using BookShopAPI.Repositories.Impl;

namespace BookShopAPI.Services.Impl;

public class ReportService : IReportService
{
    public readonly IReportRepository _reportRepository;
    public ReportService(IReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }
    public Response<List<ReportResponse>> GetAllReports()
    {
        var result = _reportRepository
            .GetAll()
            .Select(x => new ReportResponse()
            {
                ISBN = x.ISBN,
                EmployeeName = x.EmployeeName,
                CustomerName = x.CustomerName,
                EmployeeId = x.EmployeeId,
                CustomerId = x.CustomerId,
                Contact = x.Contact,
                BookTitle = x.BookTitle,
                Quantity = x.Quantity,
                Amount = x.Amount,
                SaleDate = x.SaleDate,
            })
            .ToList();
        return Response<List<ReportResponse>>.Success(result);
    }
}