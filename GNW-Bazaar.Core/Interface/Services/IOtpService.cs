using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IOtpService
    {
        Task<ResponseDto<object?>> GenerateOtp(GenerateOtpDto generateOtpDto);
        Task<ResponseDto<bool>> ValidateOtp(ValidateOtpDto validateOtpDto);
    }
}
