using BookShopClientShare.Constants;
using BookShopClientShare.Models.Requests;
using BookShopClientShare.Models.Responses;

namespace BookShopClientShare.Services;

public class SaleService
{
    private readonly RestClient _restClient;
    public SaleService()
    {
        _restClient = new(AppConstant.BaseUrl);
    }

    public async Task<Response<List<SaleResponse>>> GetAllSale()
    {
        var endpoint = "api/v1/sales";
        return await _restClient.GetAsync<Response<List<SaleResponse>>>(endpoint) ?? new();
    }

    public async Task<Response<EmployeeResponse>> Create(SaleCreateRequest request)
    {
        var endpoint = "api/v1/sales";
        return await _restClient.PostAsync<SaleCreateRequest, Response<EmployeeResponse>>(endpoint, request) ?? new();
    }
}
