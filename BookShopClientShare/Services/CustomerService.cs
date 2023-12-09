using BookShopClientShare.Constants;
using BookShopClientShare.Models.Requests;
using BookShopClientShare.Models.Responses;

namespace BookShopClientShare.Services
{
    public class CustomerService
    {
        private readonly RestClient _restClient;
        public CustomerService()
        {
            _restClient = new(AppConstant.BaseUrl);
        }

        public async Task<Response<List<CustomerResponse>>> GetAllCustomer()
        {
            var endpoint = "api/v1/customers";
            return await _restClient.GetAsync<Response<List<CustomerResponse>>>(endpoint) ?? new();
        }

        public async Task<Response<CustomerResponse>> Create(CustomerCreateRequest request)
        {
            var endpoint = "api/v1/customers";
            return await _restClient.PostAsync<CustomerCreateRequest, Response<CustomerResponse>>(endpoint, request) ?? new();
        }
    }
}
