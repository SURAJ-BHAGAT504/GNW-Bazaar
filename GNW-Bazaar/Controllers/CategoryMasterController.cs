using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazaar.Core.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CategoryMasterController(IMasterDataService<CategoryMasterDto> categoryMasterService) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await categoryMasterService.Get()));
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
                return Ok(JsonSerializer.Serialize(await categoryMasterService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CategoryMasterDto categoryMasterDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await categoryMasterService.Create(categoryMasterDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(CategoryMasterDto categoryMasterDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await categoryMasterService.Update(categoryMasterDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
