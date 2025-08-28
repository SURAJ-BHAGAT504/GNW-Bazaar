using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface IRefreshTokenClient
    {
        Task<RefreshToken?> Get(string token);
        Task<long> Create(RefreshToken entity);
        Task Update(RefreshToken entity);
    }
}
