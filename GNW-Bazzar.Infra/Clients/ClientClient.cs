using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class ClientClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<Client>
    {
        public async Task<long> Create(Client entity)
        {
            await dbContext.Clients.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<Client>> Get()=>
            await dbContext.Clients.ToListAsync();

        public async Task<Client?> Get(long id)=>
            await dbContext.Clients.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();

        public Task Update(Client entity)
        {
            dbContext.Clients.Update(entity);
            return dbContext.SaveChangesAsync();
        }
    }
}
