using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IMailService
    {
        Task<ResponseDto<object?>> SendOtpByEmail(string email, string otpCode);
    }
}
