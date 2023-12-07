using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Models.Responses;

public class Response<T>
{
    public bool Succeed { get; set; } = default;
    public string? Message { get; set; } = default;
    public T? Data { get; set; } = default;

    [JsonIgnore]
    public int Code { get; private set;}

    public static Response<T> Success(T? data, string? message = null, HttpStatusCode code = HttpStatusCode.OK)
    {
        return new Response<T>
        {
            Succeed = true,
            Code = (int)code,
            Message = message,
            Data = data,
        };
    }
    public static Response<T> Fail(string? message = null, HttpStatusCode code = HttpStatusCode.NotFound)
    {
        return new Response<T>
        {
            Succeed = false,
             Code = (int)code,
            Message = message,
            Data = default
        };
    }
}