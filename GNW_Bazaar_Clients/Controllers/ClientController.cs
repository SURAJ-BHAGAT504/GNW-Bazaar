using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar_Clients.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ClientController(IClientService clientService, IWebHostEnvironment env) : ControllerBase
    {
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await clientService.Get()));
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
                return Ok(JsonSerializer.Serialize(await clientService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] ClientDto clientDto)
        {
            try
            {
                var rootPath = env.WebRootPath
                  ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

                return Ok(JsonSerializer.Serialize(await clientService.Create(clientDto, rootPath)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update([FromForm] ClientDto clientDto)
        {
            try
            {
                var rootPath = env.WebRootPath
                   ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

                return Ok(JsonSerializer.Serialize(await clientService.Update(clientDto, rootPath)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
