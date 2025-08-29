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
    public class RefreshTokenService(ILogger logger, IRefreshTokenClient refreshTokenClient, IValidationClient validationClient,
        IMapper<RefreshTokenDto, RefreshToken> refreshTokenMapper, IMapper<RefreshToken, RefreshTokenDto> refreshTokenDtoMapper) : IRefreshTokenService
    {
        public async Task<ResponseDto<long>> Create(RefreshTokenDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                var refreshTokenEntity = refreshTokenMapper.Map(entity);

                var refreshTokenExist = await validationClient.GetRefreshToken(entity.Token);

                if (refreshTokenExist != null) throw new Exception("Refresh Token already exists");

                entity.CreatedOn = DateTime.Now;

                entity.Id = await refreshTokenClient.Create(refreshTokenMapper.Map(entity));

                return new ResponseDto<long>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Refresh Token created successfully",
                    Value = entity.Id
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "RefreshTokenService.Create");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<RefreshTokenDto?>> Get(string token)
        {
            try
            {
                if (token == null) throw new Exception("Please send Token");

                var refreshToken = await refreshTokenClient.Get(token) ?? throw new Exception($"No Token found with {token}");

                var refreshTokenDto = refreshTokenDtoMapper.Map(refreshToken);

                return new()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Refresh Token fetched successfully",
                    Value = refreshTokenDto
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "RefreshTokenService.Get");
                return new()
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> Update(RefreshTokenDto entity)
        {
            try
            {
                Validator.ValidateObject(entity, new ValidationContext(entity), true);

                if (entity.Id == 0) throw new Exception("Please enter valid Id");

                entity.UpdatedOn = DateTime.Now;

                await refreshTokenClient.Update(refreshTokenMapper.Map(entity));

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
