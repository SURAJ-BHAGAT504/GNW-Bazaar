using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class UserClient(GNW_BazaarDbContext dbContext) : IMasterDataClient<User>
    {
        public async Task<long> Create(User entity)
        {
            await dbContext.Users.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<User>> Get() =>
            await dbContext.Users.ToListAsync();

        public async Task<User?> Get(long id) =>
            await dbContext.Users.AsNoTracking().Where(u => u.Id == id).FirstOrDefaultAsync();

        public async Task Update(User entity)
        {
            dbContext.Users.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
