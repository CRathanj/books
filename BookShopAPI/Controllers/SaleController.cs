using System.ComponentModel.DataAnnotations;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers;

[Route("api/v1/Sales")]
public class SaleController : ControllerBase
{
    public readonly ISaleService _saleService;
    public SaleController(ISaleService saleService)  {
        _saleService = saleService;
    }
    /// <summary>
    /// Create a sale
    /// </summary>
    [HttpPost]
     public Response<SaleResponse> Create(SaleCreateRequest request)
    {
        var result = _saleService.Create(request);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Get all sales
    /// </summary>
    [HttpGet]
    public Response<List<SaleResponse>>  GetAll()
    {
         var result = _saleService.GetAll();
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Delete a sale
    /// </summary>
    [HttpDelete]
    public  Response<SaleResponse> Delete([Required] string id)
    {
       var result = _saleService.Delete(id);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Update a sale
    /// </summary>
    [HttpPut]
    public Response<SaleResponse> Update(SaleUpdateRequest req)
    {
         var result = _saleService.Update(req);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }
}
