using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar_Clients.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SponsorController(ISponsorService sponsorService) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await sponsorService.Get()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetByAdmin()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await sponsorService.GetByAdmin()));
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
                return Ok(JsonSerializer.Serialize(await sponsorService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetByEmail(string email)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await sponsorService.GetByEmail(email)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(SponsorDto sponsorDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await sponsorService.Create(sponsorDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpPost]
        //[Authorize]
        //public async Task<IActionResult> RecordFrequency(long sponsorId)
        //{
        //    try
        //    {
        //        return Ok(JsonSerializer.Serialize(await sponsorService.RecordFrequency(sponsorId)));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(SponsorDto sponsorDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await sponsorService.Update(sponsorDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
