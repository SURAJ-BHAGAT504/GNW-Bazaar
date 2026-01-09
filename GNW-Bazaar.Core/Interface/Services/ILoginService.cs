using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface ILoginService
    {
        Task<ResponseDto<object?>> Login(LoginDto loginDto);
        Task<ResponseDto<object?>> Logout(long userId);
        Task<ResponseDto<object?>> RefreshToken(string token);
        Task<ResponseDto<object?>> ForgotPassword(ForgotPasswordDto forgotPasswordDto);
    }
}
