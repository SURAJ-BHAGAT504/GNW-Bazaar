using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class RefreshTokenClient(GNW_BazaarDbContext dbContext) : IRefreshTokenClient
    {
        public async Task<long> Create(RefreshToken entity)
        {
            await dbContext.RefreshTokens.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(long userId)
        {
            await dbContext.RefreshTokens.Where(r => r.UserId == userId).ExecuteDeleteAsync();
            await dbContext.SaveChangesAsync();
        }

        public async Task<RefreshToken?> Get(string token) =>
            await dbContext.RefreshTokens.AsNoTracking().Where(r => r.Token == token).FirstOrDefaultAsync();

        public async Task Update(RefreshToken entity)
        {
            dbContext.RefreshTokens.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
