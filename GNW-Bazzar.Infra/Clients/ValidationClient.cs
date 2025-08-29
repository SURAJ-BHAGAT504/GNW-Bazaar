using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class ValidationClient(GNW_BazaarDbContext dbContext) : IValidationClient
    {
        public async Task<HealthCareCategory?> GetHealthCareCategory(string category) =>
            await dbContext.HealthCareCategories.Where(h => h.Category == category).FirstOrDefaultAsync();

        public async Task<RefreshToken?> GetRefreshToken(string token) =>
            await dbContext.RefreshTokens.Where(t => t.Token == token).FirstOrDefaultAsync();
    }
}
