
using BookShopAPI.Models.Responses;
using BookShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers;

[Route("api/v1/report")]
public class ReportController : ControllerBase
{
    private readonly IReportService _reportService;

    public ReportController(IReportService reportService)
    {
        _reportService = reportService;
    }
    /// <summary>
    /// Get all reports
    /// </summary>
    [HttpGet]
    public Response<List<ReportResponse>> GetAll()
    {
         var result = _reportService.GetAllReports();
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

}
