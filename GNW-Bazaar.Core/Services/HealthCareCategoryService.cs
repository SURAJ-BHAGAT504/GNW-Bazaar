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
    public class HealthCareCategoryService(ILogger<HealthCareCategoryService> logger, IMapper<HealthCareCategoryDto, HealthCareCategory> healthCareCategoryMapper,
        IMasterDataClient<HealthCareCategory> healthCareCategoryClient, IValidationClient validationClient, IMapper<HealthCareCategory, HealthCareCategoryDto> healthCareCategoryDtoMapper) : IMasterDataService<HealthCareCategoryDto>
    {
        public async Task<ResponseDto<long>> Create(HealthCareCategoryDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var healthCareCategoryEntity = healthCareCategoryMapper.Map(entity);

                var healthCareCategoryExist = await validationClient.GetHealthCareCategory(entity.Category);

                if (healthCareCategoryExist != null) throw new Exception("HealthCare Category already exists");

                entity.CreatedOn = DateTime.Now;

                entity.Id = await healthCareCategoryClient.Create(healthCareCategoryMapper.Map(entity));

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "HealthCare Category created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "HealthCareCategoryService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<HealthCareCategoryDto>>> Get()
        {
            try
            {
                var healthCareCategory = await healthCareCategoryClient.Get();

                var healthCareCategoryDtos = new List<HealthCareCategoryDto>();

                if (healthCareCategory != null && healthCareCategory.Any())
                {
                    healthCareCategoryDtos = healthCareCategory.Select(healthCareCategory => healthCareCategoryDtoMapper.Map(healthCareCategory)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "HealthCare categories fetched successfully",
                    Value = healthCareCategoryDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "HealthCareCategoryService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<HealthCareCategoryDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Please enter valid Id");

                var healthCareCategory = await healthCareCategoryClient.Get(id) ?? throw new Exception($"No healthcare category found with Id {id}");

                var healthCareCategoryDto = healthCareCategoryDtoMapper.Map(healthCareCategory);
                
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "HealthCare category fetched successfully",
                    Value = healthCareCategoryDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "HealthCareCategoryService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(HealthCareCategoryDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                entity.UpdatedOn = DateTime.Now;

                await healthCareCategoryClient.Update(healthCareCategoryMapper.Map(entity));

                return new ResponseDto<bool>()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "HealthCare Category updated successfully",
                    Value = true
                };

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "HealthCareCategoryService.Update");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
