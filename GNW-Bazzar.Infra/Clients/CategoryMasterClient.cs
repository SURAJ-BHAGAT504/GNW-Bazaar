using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class CategoryMasterClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<CategoryMaster>
    {
        public async Task<long> Create(CategoryMaster entity)
        {
            await dbContext.CategoryMasters.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<CategoryMaster>> Get() =>
            await dbContext.CategoryMasters.ToListAsync();

        public async Task<CategoryMaster?> Get(long id) =>
            await dbContext.CategoryMasters.Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task Update(CategoryMaster entity)
        {
            dbContext.CategoryMasters.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
