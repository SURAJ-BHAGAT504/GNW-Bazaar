using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class SubCategoryMasterService(ILogger<SubCategoryMasterService> logger, IMapper<SubCategoryMasterDto, SubCategoryMaster> subCategoryMasterMapper,
        IMapper<SubCategoryMaster, SubCategoryMasterDto> subCategoryMasterDtoMapper, IMasterDataClient<SubCategoryMaster> subCategoryMaterClient,
        IValidationClient validationClient) : IMasterDataService<SubCategoryMasterDto>
    {
        public async Task<ResponseDto<long>> Create(SubCategoryMasterDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var subCategoryMasterEntity = subCategoryMasterMapper.Map(entity);

                var subCategoryMasterExist = await validationClient.GetSubCategoryMaster(entity.CategoryName);

                if (subCategoryMasterExist != null) throw new Exception("Sub category master already exists");

                entity.CreatedOn = DateTime.Now;

                entity.Id = await subCategoryMaterClient.Create(subCategoryMasterMapper.Map(entity));

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sub category master created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SubCategoryMasterService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<SubCategoryMasterDto>>> Get()
        {
            try
            {
                var subCategoryMaster = await subCategoryMaterClient.Get();

                var subCategoryMasterDtos = new List<SubCategoryMasterDto>();

                if (subCategoryMaster != null && subCategoryMaster.Any())
                {
                    subCategoryMasterDtos = subCategoryMaster.Select(subCategoryMaster => subCategoryMasterDtoMapper.Map(subCategoryMaster)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sub category master fetched successfully",
                    Value = subCategoryMasterDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SubCategoryMasterService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<SubCategoryMasterDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Please enter valid Id");

                var subCategoryMaster = await subCategoryMaterClient.Get(id) ?? throw new Exception($"No category master found with Id {id}");

                var subCategoryMasterDto = subCategoryMasterDtoMapper.Map(subCategoryMaster);

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sub category master fetched successfully",
                    Value = subCategoryMasterDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SubCategoryMasterService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(SubCategoryMasterDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                entity.UpdatedOn = DateTime.Now;

                await subCategoryMaterClient.Update(subCategoryMasterMapper.Map(entity));

                return new ResponseDto<bool>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Sub category master updated successfully",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "SubCategoryMasterService.Update");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
