using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar_Otp.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class OtpController(IOtpService otpService) : ControllerBase
    {
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GenerateOtp([FromForm] GenerateOtpDto generateOtpDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await otpService.GenerateOtp(generateOtpDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ValidateOtp([FromForm] ValidateOtpDto validateOtpDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await otpService.ValidateOtp(validateOtpDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
