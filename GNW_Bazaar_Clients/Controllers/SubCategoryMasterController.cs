using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GNW_Bazaar_Clients.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SubCategoryMasterController(ISubCategoryMasterService subCategoryMasterService) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await subCategoryMasterService.Get()));
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
                return Ok(JsonSerializer.Serialize(await subCategoryMasterService.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetByMasterCategory(long id)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await subCategoryMasterService.GetByMasterCategory(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(SubCategoryMasterDto subCategoryMasterDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await subCategoryMasterService.Create(subCategoryMasterDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(SubCategoryMasterDto subCategoryMasterDto)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(await subCategoryMasterService.Update(subCategoryMasterDto)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
