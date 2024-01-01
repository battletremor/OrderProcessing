using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Auth.Models;

namespace OrderProcessing.Auth.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(JwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }
        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel user)
        {
            var loginResult = _jwtTokenService.GenerateAuthToken(user);

            return loginResult is null ? Unauthorized() : Ok(loginResult);
        }
    }
}
