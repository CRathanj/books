using BookShopAPI.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers;

[Route("api/v1/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost("login")]
    public IActionResult Login([FromForm] AuthRequest request)
    {
        Console.WriteLine(request.Username);
        Console.WriteLine(request.Password);

        if (
            string.IsNullOrWhiteSpace(request.Username)
            || string.IsNullOrWhiteSpace(request.Password))
        {
            return NotFound("Incorrect Username or Password!");
        }

        return Ok("Login successfully");
    }

    [HttpPost("refresh-token")]
    public string RefreshToken() {
        return "Success";
    }

}