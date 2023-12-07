
using System.ComponentModel.DataAnnotations;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers;

[Route("api/v1/employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    /// <summary>
    /// Create a employee
    /// </summary>
    [HttpPost]
    public Response<EmployeeResponse> Create(EmployeeCreateRequest request)
    {
        var result = _employeeService.Create(request);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Get all employees
    /// </summary>
    [HttpGet]
    public Response<List<EmployeeResponse>> GetAll()
    {
        var result = _employeeService.GetAll();
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Delete a employee
    /// </summary>
    [HttpDelete]
    public Response<EmployeeResponse> Delete([Required] string id)
    {
        var result = _employeeService.Delete(id);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Update a employee
    /// </summary>
    [HttpPut]
    public Response<EmployeeResponse> Update(EmployeeUpdateRequest req)
    {
        var result = _employeeService.Update(req);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }
}