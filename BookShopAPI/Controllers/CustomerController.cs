using System.ComponentModel.DataAnnotations;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers;

[Route("api/v1/customers")]
public class CustomerController : ControllerBase
{

    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    /// <summary>
    /// Create a customer
    /// </summary>
    [HttpPost]
    public Response<CustomerResponse> Create(CustomerCreateRequest request)
    {
        var result = _customerService.Create(request);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Get all customers
    /// </summary>
    [HttpGet]
    public Response<List<CustomerResponse>> GetAll()
    {
        var result = _customerService.GetAll();
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Delete a customer
    /// </summary>
    [HttpDelete]
    public Response<CustomerResponse> Delete([Required] string id)
    {
        var result = _customerService.Delete(id);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Update a customer
    /// </summary>
    [HttpPut]
    public Response<CustomerResponse> Update(CustomerUpdateRequest req)
    {
        var result = _customerService.Update(req);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }
}
