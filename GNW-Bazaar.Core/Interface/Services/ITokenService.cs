using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface ITokenService
    {
        public string GenerateAccessToken(UserDto userDto);
        public RefreshTokenDto GenerateRefreshToken(long userId);
    }
}
