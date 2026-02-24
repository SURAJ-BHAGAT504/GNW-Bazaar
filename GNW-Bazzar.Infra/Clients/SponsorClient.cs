using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class SponsorClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<Sponsor>
    {
        public async Task<long> Create(Sponsor entity)
        {
            await dbContext.Sponsors.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<Sponsor>> Get() =>
            await dbContext.Sponsors.ToListAsync();

        public async Task<Sponsor?> Get(long id) =>
            await dbContext.Sponsors.AsNoTracking().Where(s => s.Id == id).FirstOrDefaultAsync();

        public async Task Update(Sponsor entity)
        {
            dbContext.Sponsors.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
