using BookShopClientShare.Constants;
using BookShopClientShare.Models.Requests;
using BookShopClientShare.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopClientShare.Services
{
    public class EmployeeService
    {
        private readonly RestClient _restClient;
        public EmployeeService()
        {
            _restClient = new(AppConstant.BaseUrl);
        }

        public async Task<Response<List<EmployeeResponse>>> GetAllEmployee()
        {
            var endpoint = "api/v1/employees";
            return await _restClient.GetAsync<Response<List<EmployeeResponse>>>(endpoint) ?? new();
        }

        public async Task<Response<EmployeeResponse>> Create(EmployeeCreateRequest request)
        {
            var endpoint = "api/v1/employees";
            return await _restClient.PostAsync<EmployeeCreateRequest, Response<EmployeeResponse>>(endpoint, request) ?? new();
        }
    }
}
