using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface IValidationClient
    {
        public Task<HealthCareCategory?> GetHealthCareCategory(string category);
        public Task<RefreshToken?> GetRefreshToken(string token);
    }
}
