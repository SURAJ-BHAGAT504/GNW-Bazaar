using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DoctorController(IDoctorService doctorService, IWebHostEnvironment env) : ControllerBase
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetBySubCategoryId(long subCategoryId)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await doctorService.GetDoctorBySubCategoryId(subCategoryId)));
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
                var rootPath = env.WebRootPath
                   ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

                return Ok(JsonSerializer.Serialize(await doctorService.Create(doctorDto, rootPath)));
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
                var rootPath = env.WebRootPath
                   ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

                return Ok(JsonSerializer.Serialize(await doctorService.Update(doctorDto, rootPath)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
