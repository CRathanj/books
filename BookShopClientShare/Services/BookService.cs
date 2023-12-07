using BookShopClientShare.Constants;
using BookShopClientShare.Models.Requests;
using BookShopClientShare.Models.Responses;

namespace BookShopClientShare.Services
{
    public class BookService
    {
        private readonly RestClient _restClient;
        public BookService()
        {
            _restClient = new(AppConstant.BaseUrl);
        }

        public async Task<Response<List<BookResponse>>> GetAllBooks()
        {
            var endpoint = "api/v1/books";
            return await _restClient.GetAsync<Response<List<BookResponse>>>(endpoint) ?? new();
        }

        public async Task<Response<BookResponse>> Create(BookCreateRequest request)
        {
            var endpoint = "api/v1/books";
            return await _restClient.PostAsync<BookCreateRequest, Response<BookResponse>>(endpoint, request) ?? new();
        }
    }
}