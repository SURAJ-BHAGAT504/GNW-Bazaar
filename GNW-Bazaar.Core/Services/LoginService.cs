using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class LoginService(ILogger<LoginService> logger, IValidationClient validationClient, ITokenService tokenService, IMapper<User, UserDto> userDtoMapper,
        IRefreshTokenService refreshTokenService, IMasterDataService<UserDto> userService) : ILoginService
    {
        public async Task<ResponseDto<object?>> Login(LoginDto loginDto)
        {
            try
            {
                Validator.ValidateObject(loginDto, new ValidationContext(loginDto), true);

                var user = await validationClient.GetUser(loginDto.Email);
                if (user == null)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.Unauthorized,
                        Message = "Invalid Email or Password"
                    };
                }

                var userDto = userDtoMapper.Map(user);

                var passwordHasher = new PasswordHasher<UserDto>();
                var verificationResult = passwordHasher.VerifyHashedPassword(userDto, userDto.Password, loginDto.Password);

                if (verificationResult == PasswordVerificationResult.Failed)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.Unauthorized,
                        Message = "Invalid email or password",
                        Value = null
                    };
                }

                var accessToken = tokenService.GenerateAccessToken(userDto);
                var refreshTokenEntity = tokenService.GenerateRefreshToken(userDto.Id);

                await refreshTokenService.Create(refreshTokenEntity);

                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Login successful",
                    Value = new
                    {
                        user.Id,
                        user.Email,
                        user.Name,
                        accessToken,
                        refreshTokenEntity.Token
                    }
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "LoginService.Login");
                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<object?>> RefreshToken(string token)
        {
            try
            {
                var existingTokenResult = await refreshTokenService.Get(token);

                if (existingTokenResult.Value == null || existingTokenResult.Value.ExpiryDate < DateTime.Now)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.Unauthorized,
                        Message = "Invalid or expired refresh token"
                    };
                }

                var existingToken = existingTokenResult.Value;

                var user = await userService.Get(existingToken.UserId); ;

                if (user.Value == null)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.Unauthorized,
                        Message = "User not found"
                    };
                }

                var AccessToken = tokenService.GenerateAccessToken(user.Value);
                var refreshTokenEntity = tokenService.GenerateRefreshToken(user.Value.Id);

                refreshTokenEntity.Id = existingToken.Id;
                refreshTokenEntity.CreatedOn = existingToken.CreatedOn;
                refreshTokenEntity.UpdatedOn = DateTime.Now;

                await refreshTokenService.Update(refreshTokenEntity);

                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Token refreshed successfully",
                    Value = new
                    {
                        user.Value.Id,
                        user.Value.Email,
                        user.Value.Name,
                        accessToken = AccessToken,
                        refreshToken = refreshTokenEntity.Token
                    }
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "LoginService.RefreshToken");
                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
