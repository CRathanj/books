using BookShopClientShare.Constants;
using BookShopClientShare.Models.Responses;

namespace BookShopClientShare.Services;

public class GenresService
{
    private readonly RestClient _restClient;
    public GenresService()
    {
        _restClient = new(AppConstant.BaseUrl);
    }

    public async Task<Response<List<GenresResponse>>> GetAllGenres()
    {
        var endpoint = "api/v1/genres";
        return await _restClient.GetAsync<Response<List<GenresResponse>>>(endpoint) ?? new();
    }
}
