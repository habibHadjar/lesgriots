using Lesgriots.Application;
using Microsoft.AspNetCore.Mvc;

namespace Lesgriots.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _authService.AuthenticateAsync(request.Mail, request.Password);
            if (result == null) return Unauthorized("Invalid credentials");
            return Ok(result);
        }
        //[HttpPost("login")]
        //public async Task<IActionResult> Login(string email, string password)
        //{
        //    var result = await _authService.AuthenticateAsync(email, password);
        //    if (result == null) return Unauthorized("Invalid credentials");
        //    return Ok(result);
        //}
    }

    public class LoginRequest
    {
        public string Mail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
