using Microsoft.AspNetCore.Mvc;
using SMConsulting.BL.DTOs.Auth;
using SMConsulting.BL.Services.Abstracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMConsulting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController(IAuthService _service) : ControllerBase
    {

        ///// <summary>
        ///// Registers a new user in the system
        ///// </summary>
        ///// <param name="dto">User registration data</param>
        ///// <returns>Success response</returns>
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            await _service.RegisterAsync(dto);
            return Ok();
        }

        /// <summary>
        /// Authenticates a user and returns an access token
        /// </summary>
        /// <param name="dto">User login credentials</param>
        /// <returns>JWT token or authentication result</returns>
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(await _service.LoginAsync(dto));
        }
        /// <summary>
        /// Generates new access token using refresh token
        /// </summary>
        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] string refreshToken)
        {
            var result = await _service.RefreshAsync(refreshToken);
            return Ok(result);
        }
        /// <summary>
        /// Logs out user by revoking refresh token
        /// </summary>
        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] string refreshToken)
        {
            await _service.LogoutAsync(refreshToken);
            return Ok("Logouted");
        }
    }
}
