using System.Net.Http.Json;
using System.Text.Json;

namespace BookShopClientShare
{
    public class RestClient
{
    private readonly HttpClient _httpClient;

    public string BaseUri
        {
            get => _httpClient.BaseAddress.AbsoluteUri;
            set
            {
                _httpClient.BaseAddress = new Uri(value);
            }
        }

        public RestClient(string baseUri)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUri)
        };
    }

    public async Task<TResponse?> GetAsync<TResponse>(string endpoint)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>((JsonSerializerOptions?)null, default(CancellationToken));
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(endpoint, data);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>((JsonSerializerOptions?)null, default(CancellationToken));
    }

    public async Task<TResponse?> PostAsync<TResponse>(string endpoint)
    {
        HttpResponseMessage response = await _httpClient.PostAsync(endpoint, null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>((JsonSerializerOptions?)null, default(CancellationToken));
    }

    public async Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        HttpResponseMessage response = await _httpClient.PutAsJsonAsync(endpoint, data);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>((JsonSerializerOptions?)null, default(CancellationToken));
    }

    public async Task<TResponse?> DeleteAsync<TResponse>(string endpoint)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(endpoint);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>((JsonSerializerOptions?)null, default(CancellationToken));
    }
}
}