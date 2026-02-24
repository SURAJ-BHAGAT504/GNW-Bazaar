using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class ValidationClient(GNW_BazaarDbContext dbContext) : IValidationClient
    {
        public async Task<CategoryMaster?> GetCategoryMaster(string categoryName) =>
            await dbContext.CategoryMasters.AsNoTracking().Where(c => c.CategoryName == categoryName).FirstOrDefaultAsync();

        public async Task<Client?> GetClient(string email) =>
            await dbContext.Clients.AsNoTracking().Where(c => c.Email == email).FirstOrDefaultAsync();

        public async Task<Doctor?> GetDoctor(string email) =>
            await dbContext.Doctors.AsNoTracking().Where(d => d.Email == email).FirstOrDefaultAsync();

        public async Task<HealthCareCategory?> GetHealthCareCategory(string category) =>
            await dbContext.HealthCareCategories.Where(h => h.Category == category).FirstOrDefaultAsync();

        public async Task<Otp?> GetOtp(long userId, string purpose) =>
            await dbContext.Otps.AsNoTracking().Where(o => o.UserId == userId && o.Purpose == purpose).FirstOrDefaultAsync();

        public async Task<RefreshToken?> GetRefreshToken(string token) =>
            await dbContext.RefreshTokens.AsNoTracking().Where(t => t.Token == token).FirstOrDefaultAsync();

        public async Task<List<Sponsor>> GetSponsoeClient(string email) =>
            await dbContext.Sponsors.Where(s => s.Email == email).ToListAsync();

        public async Task<User?> GetUser(string email) =>
            await dbContext.Users.AsNoTracking().Where(u => u.Email == email).FirstOrDefaultAsync();
    }
}
