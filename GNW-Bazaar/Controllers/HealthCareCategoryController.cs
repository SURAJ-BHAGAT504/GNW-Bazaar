using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HealthCareCategoryController(IMasterDataService<HealthCareCategoryDto> healthCareCategoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await healthCareCategoryService.Get()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await healthCareCategoryService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
