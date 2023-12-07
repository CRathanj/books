using BookShop.Models.Responses;
using BookShopAPI.Models;
using BookShopAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers;

[Route("api/v1/genres")]

public class GenresController : ControllerBase
{

    /// <summary>
    /// Get all genres
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<List<GenresResponse>>))]
    public Response<List<GenresResponse>> GetAll()
    {
        var result = Enum.GetValues(typeof(Genres))
            .Cast<Genres>()
            .Select(v => new GenresResponse { Id = (int)v, Name = v.ToString()})
            .ToList();

        return Response<List<GenresResponse>>.Success(result);
    }
}
