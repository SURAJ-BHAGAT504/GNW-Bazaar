using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar_SignupAndLogin.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SignUpAndLoginController(IMasterDataService<UserDto> userService, ILoginService loginService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] UserDto userDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await userService.Create(userDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginDto loginDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await loginService.Login(loginDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout([FromForm] long userId)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await loginService.Logout(userId)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken([FromForm] string token)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await loginService.RefreshToken(token)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword([FromForm] ForgotPasswordDto forgotPasswordDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await loginService.ForgotPassword(forgotPasswordDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
