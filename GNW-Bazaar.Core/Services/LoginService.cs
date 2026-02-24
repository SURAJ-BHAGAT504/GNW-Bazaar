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
        IRefreshTokenService refreshTokenService, IMasterDataService<UserDto> userService, IRefreshTokenClient refreshTokenClient,
        IMasterDataClient<User> userClient, IMasterDataClient<Otp> otpClient) : ILoginService
    {
        public async Task<ResponseDto<object?>> ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(forgotPasswordDto.Email) ||
                    string.IsNullOrWhiteSpace(forgotPasswordDto.Password))
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.BadRequest,
                        Message = "Invalid input. Email and new Password are required."
                    };
                }

                var user = await validationClient.GetUser(forgotPasswordDto.Email);
                if (user == null)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.NotFound,
                        Message = "User not found."
                    };
                }

                var otp = await otpClient.Get(user.Id);

                if(otp == null || otp.Purpose != forgotPasswordDto.Purpose || otp.IsUsed == false || otp.IsVerified == false)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.BadRequest,
                        Message = "Invalid or expired OTP."
                    };
                }

                var userDto = userDtoMapper.Map(user);
                var passwordHasher = new PasswordHasher<UserDto>();
                userDto.Password = passwordHasher.HashPassword(userDto, forgotPasswordDto.Password);

                userDto.UpdatedOn = DateTime.Now;
                await userService.Update(userDto);

                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Password changed successfully. You can now login with your new password.",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "LoginService.ForgotPassword Error for Email: {Email}", forgotPasswordDto.Email);
                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

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
                        Message = "Please signup before login"
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

                userDto.IsActive = true;
                userDto.LastLogin = DateTime.Now;

                await userService.Update(userDto);

                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "Login successful",
                    Value = new
                    {
                        user.Id,
                        user.Email,
                        user.Name,
                        user.UserRole,
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

        public async Task<ResponseDto<object?>> Logout(long userId)
        {
            try
            {
                if (userId == 0) throw new Exception("Please enter valid Id");

                var user = await userClient.Get(userId);
                if (user == null)
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.NotFound,
                        Message = "Something went wrong"
                    };
                }

                var userDto = userDtoMapper.Map(user);

                await userService.Update(new UserDto
                {
                    Id = userDto.Id,
                    Name = userDto.Name,
                    Email = userDto.Email,
                    PhoneNumber = userDto.PhoneNumber,
                    Password = userDto.Password,
                    UserRole = userDto.UserRole,
                    IsActive = false,
                    CreatedOn = userDto.CreatedOn,
                    LastLogin = userDto.LastLogin,
                    UpdatedOn = DateTime.Now
                });

                await refreshTokenClient.Delete(userId);

                return new ResponseDto<object?>()
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "User logout successfully",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "LoginService.Logout");
                return new()
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

                var user = await userService.Get(existingToken.UserId);

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
