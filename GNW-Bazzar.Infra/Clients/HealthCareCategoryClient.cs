using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class HealthCareCategoryClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<HealthCareCategory>
    {
        public async Task<long> Create(HealthCareCategory entity)
        {
            await dbContext.HealthCareCategories.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<HealthCareCategory>> Get() =>
            await dbContext.HealthCareCategories.ToListAsync();

        public async Task<HealthCareCategory?> Get(long id) =>
            await dbContext.HealthCareCategories.Where(h => h.Id == id).FirstOrDefaultAsync();

        public async Task Update(HealthCareCategory entity)
        {
            dbContext.HealthCareCategories.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
