namespace BookShopClientShare.Models.Responses;

public class Response<T>
{
    public bool Succeed { get; set; } = default;
    public string? Message { get; set; } = default;
    public T? Data { get; set; } = default;

    public static Response<T> Success(T? data, string? message = null)
    {
        return new Response<T>()
        {
            Succeed = true,
            Message = message,
            Data = data,
        };
    }
    public static Response<T> Fail(string? message = null)
    {
        return new Response<T>()
        {
            Succeed = false,
            Message = message,
            Data = default
        };
    }
}