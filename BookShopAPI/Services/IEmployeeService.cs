using BookShop.Contracts;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Services;

public interface IEmployeeService : IService<EmployeeResponse, EmployeeCreateRequest, EmployeeUpdateRequest>
{

}
