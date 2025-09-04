using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface IValidationClient
    {
        public Task<HealthCareCategory?> GetHealthCareCategory(string category);
        public Task<RefreshToken?> GetRefreshToken(string token);
        public Task<Doctor?> GetDoctor(string email);
        public Task<User?> GetUser(string email);
        public Task<Otp?> GetOtp(long userId, string purpose);
        public Task<CategoryMaster?> GetCategoryMaster(string categoryName);
    }
}
