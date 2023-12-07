using BookShop.Contracts;
using BookShop.Models.Requests;
using BookShop.Models.Responses;

namespace BookShop.Services;
public interface IBookService : IService<BookResponse, BookCreateRequest, BookUpdateRequest>
{
}

// Main Service