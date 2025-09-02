using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using Microsoft.Extensions.Logging;
using System.Net;

namespace GNW_Bazaar.Core.Services
{
    public class OtpService(ILogger<OtpService> logger, IMasterDataClient<Otp> otpClient, IValidationClient validationClient) : IOtpService
    {
        public async Task<ResponseDto<object?>> GenerateOtp(GenerateOtpDto generateOtpDto)
        {
            try
            {
                if (generateOtpDto.UserId <= 0 || string.IsNullOrWhiteSpace(generateOtpDto.Purpose))
                {
                    return new ResponseDto<object?>
                    {
                        ResponseCode = (int)HttpStatusCode.BadRequest,
                        Message = "Invalid input"
                    };
                }

                var random = new Random();
                var otpCode = random.Next(1000, 9999).ToString();

                var existingOtp = await otpClient.Get(generateOtpDto.UserId);

                if (existingOtp != null)
                {
                    existingOtp.UserId = generateOtpDto.UserId;
                    existingOtp.Purpose = generateOtpDto.Purpose;
                    existingOtp.OtpCode = otpCode;
                    existingOtp.ExpiresOn = DateTime.UtcNow.AddMinutes(5);
                    existingOtp.IsUsed = false;
                    existingOtp.Attempts = 0;
                    existingOtp.UpdatedOn = DateTime.UtcNow;

                    await otpClient.Update(existingOtp);
                }
                else
                {
                    var newOtp = new Otp
                    {
                        UserId = generateOtpDto.UserId,
                        Purpose = generateOtpDto.Purpose,
                        OtpCode = otpCode,
                        ExpiresOn = DateTime.UtcNow.AddMinutes(5),
                        IsUsed = false,
                        Attempts = 0,
                        CreatedOn = DateTime.UtcNow
                    };

                    await otpClient.Create(newOtp);
                }

                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "OTP generated successfully",
                    Value = new
                    {
                        userId = generateOtpDto.UserId,
                        OtpCode = otpCode
                    }
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "GenerateOtp.Service");
                return new ResponseDto<object?>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }

        public async Task<ResponseDto<bool>> ValidateOtp(ValidateOtpDto validateOtpDto)
        {
            try
            {
                if (validateOtpDto.UserId <= 0 || string.IsNullOrWhiteSpace(validateOtpDto.Purpose) || string.IsNullOrWhiteSpace(validateOtpDto.Otp))
                {
                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.BadRequest,
                        Message = "Invalid input",
                        Value = false
                    };
                }

                var existingOtp = await validationClient.GetOtp(validateOtpDto.UserId, validateOtpDto.Purpose);

                if (existingOtp == null)
                {
                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.NotFound,
                        Message = "OTP not found",
                        Value = false
                    };
                }

                if (existingOtp.ExpiresOn < DateTime.UtcNow)
                {
                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.Gone,
                        Message = "OTP expired",
                        Value = false
                    };
                }

                if (existingOtp.IsUsed)
                {
                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.Conflict,
                        Message = "OTP already used",
                        Value = false
                    };
                }

                if (existingOtp.Attempts >= 5)
                {
                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.Locked,
                        Message = "Maximum attempts exceeded. Please request a new OTP.",
                        Value = false
                    };
                }

                if (existingOtp.OtpCode != validateOtpDto.Otp)
                {
                    existingOtp.Attempts += 1;
                    existingOtp.UpdatedOn = DateTime.UtcNow;
                    await otpClient.Update(existingOtp);

                    return new ResponseDto<bool>
                    {
                        ResponseCode = (int)HttpStatusCode.Unauthorized,
                        Message = "Invalid OTP",
                        Value = false
                    };
                }

                existingOtp.IsUsed = true;
                existingOtp.UpdatedOn = DateTime.UtcNow;
                await otpClient.Update(existingOtp);

                return new ResponseDto<bool>
                {
                    ResponseCode = (int)HttpStatusCode.OK,
                    Message = "OTP verified successfully",
                    Value = true
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ValidateOtp.Service");
                return new ResponseDto<bool>
                {
                    ResponseCode = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Value = false
                };
            }
        }
    }
}
