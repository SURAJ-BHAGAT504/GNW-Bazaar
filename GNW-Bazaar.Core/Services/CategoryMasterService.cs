using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazaar.Core.Mappers.Entity;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class CategoryMasterService(ILogger<CategoryMasterService> logger, IMapper<CategoryMasterDto, CategoryMaster> categoryMasterMapper,
        IMasterDataClient<CategoryMaster> categoryMasterClient, IValidationClient validationClient, IMapper<CategoryMaster, CategoryMasterDto> categoryMasterDtoMapper) : IMasterDataService<CategoryMasterDto>
    {
        public async Task<ResponseDto<long>> Create(CategoryMasterDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var categoryMasterEntity = categoryMasterMapper.Map(entity);

                var categoryMasterExist = await validationClient.GetUser(entity.CategoryName);

                if (categoryMasterExist != null) throw new Exception("Category master already exists");

                entity.CreatedOn = DateTime.Now;

                entity.Id = await categoryMasterClient.Create(categoryMasterMapper.Map(entity));

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Category master created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "CategoryMasterService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<List<CategoryMasterDto>>> Get()
        {
            try
            {
                var categoryMaster = await categoryMasterClient.Get();

                var categoryMasterDtos = new List<CategoryMasterDto>();

                if (categoryMaster != null && categoryMaster.Any())
                {
                    categoryMasterDtos = categoryMaster.Select(categoryMaster => categoryMasterDtoMapper.Map(categoryMaster)).ToList();
                }

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Category Masters fetched successfully",
                    Value = categoryMasterDtos
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "CategoryMasterService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<CategoryMasterDto?>> Get(long id)
        {
            try
            {
                if (id == 0) throw new Exception("Please enter valid Id");

                var categoryMaster = await categoryMasterClient.Get(id) ?? throw new Exception($"No category master found with Id {id}");

                var categoryMasterDto = categoryMasterDtoMapper.Map(categoryMaster);

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Category master fetched successfully",
                    Value = categoryMasterDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "CategoryMasterService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(CategoryMasterDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                entity.UpdatedOn = DateTime.Now;

                await categoryMasterClient.Update(categoryMasterMapper.Map(entity));

                return new ResponseDto<bool>()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Category master updated successfully",
                    Value = true
                };

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "CategoryMasterService.Update");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
