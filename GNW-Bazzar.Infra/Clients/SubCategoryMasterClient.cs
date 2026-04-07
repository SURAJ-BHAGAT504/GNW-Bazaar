using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class SubCategoryMasterClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<SubCategoryMaster>
    {
        public async Task<long> Create(SubCategoryMaster entity)
        {
            await dbContext.SubCategoryMasters.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<SubCategoryMaster>> Get() =>
            await dbContext.SubCategoryMasters.ToListAsync();

        public async Task<SubCategoryMaster?> Get(long id) =>
            await dbContext.SubCategoryMasters.Where(h => h.Id == id).FirstOrDefaultAsync();

        public Task Update(SubCategoryMaster entity)
        {
            dbContext.SubCategoryMasters.Update(entity);
            return dbContext.SaveChangesAsync();    
        }
    }
}
