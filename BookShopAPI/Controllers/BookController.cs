using System.ComponentModel.DataAnnotations;
using BookShop.Models.Requests;
using BookShop.Models.Responses;
using BookShop.Services;
using BookShopAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers;

[Route("api/v1/books")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }


    /// <summary>
    /// Create a book
    /// </summary>
    /// <remarks>
    /// To create a book by given required information!
    /// - $date-time: The date format, for example, 2017-07-21
    /// - $double: 5.6, 50
    /// </remarks>
    /// <response code="201">Book created</response>
    /// <response code="409">Book has missing/invalid values</response>
    /// <response code="500">Oops! Can't create your Book right now</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Response<BookResponse>))]
    [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(Response<>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response<>))]
    public Response<BookResponse> Create([FromForm] BookCreateRequest request)
    {
        var result = _bookService.Create(request);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Get all books
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<List<BookResponse>>))]
    public Response<List<BookResponse>> GetAll()
    {
        var result = _bookService.GetAll();
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Delete a book
    /// </summary>
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response<string>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response<string>))]
    public Response<BookResponse> Delete([Required] string id)
    {
        var result = _bookService.Delete(id);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }

    /// <summary>
    /// Update a book
    /// </summary>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response<BookResponse>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response<string>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response<string>))]
    public Response<BookResponse> Update(BookUpdateRequest req)
    {
        var result = _bookService.Update(req);
        HttpContext.Response.StatusCode = result.Code;
        return result;
    }
}
