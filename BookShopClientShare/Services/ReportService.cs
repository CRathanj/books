using BookShopClientShare.Constants;
using BookShopClientShare.Models.Responses;

namespace BookShopClientShare.Services;

public class ReportService
{
    private readonly RestClient _restClient;
    public ReportService()
    {
        _restClient = new(AppConstant.BaseUrl);
    }

    public async Task<Response<List<ReportResponse>>> GetAllReport()
    {
        var endpoint = "api/v1/report";
        return await _restClient.GetAsync<Response<List<ReportResponse>>>(endpoint) ?? new();
    }
}
