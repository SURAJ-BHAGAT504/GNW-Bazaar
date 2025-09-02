using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class OtpClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<Otp>
    {
        public async Task<long> Create(Otp entity)
        {
            await dbContext.Otps.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<Otp>> Get() =>
            await dbContext.Otps.ToListAsync();

        public async Task<Otp?> Get(long userId) =>
            await dbContext.Otps.AsNoTracking().Where(o => o.UserId == userId).FirstOrDefaultAsync();

        public async Task Update(Otp entity)
        {
            dbContext.Otps.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
