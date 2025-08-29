using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IRefreshTokenService
    {
        Task<ResponseDto<RefreshTokenDto?>> Get(string token);
        Task<ResponseDto<long>> Create(RefreshTokenDto entity);
        Task<ResponseDto<bool>> Update(RefreshTokenDto entity);
    }
}
