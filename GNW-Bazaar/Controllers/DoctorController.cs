using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DoctorController(IMasterDataService<DoctorDto> doctorService) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await doctorService.Get()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await doctorService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] DoctorDto doctorDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await doctorService.Create(doctorDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(DoctorDto doctorDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await doctorService.Update(doctorDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
