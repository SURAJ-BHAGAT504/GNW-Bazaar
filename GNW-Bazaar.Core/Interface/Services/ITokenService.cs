using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface ITokenService
    {
        public string GenerateAccessToken(string userId, string userName);
        public RefreshToken GenerateRefreshToken(string userId);
    }
}
