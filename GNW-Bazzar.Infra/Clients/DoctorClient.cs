using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazzar.Entity;
using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Infra.Clients
{
    public class DoctorClient(GNW_BazaarDbContext dbContext) : IDoctorClient
    {
        public async Task<long> Create(Doctor entity)
        {
            await dbContext.Doctors.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<List<Doctor>> Get() =>
            await dbContext.Doctors.ToListAsync();

        public async Task<Doctor?> Get(long id) =>
            await dbContext.Doctors.AsNoTracking().Where(d => d.Id == id).FirstOrDefaultAsync();

        public async Task<List<Doctor>> GetDoctorBySubCategoryId(long subCategoryId) =>
            await dbContext.Doctors.Where(d => d.HealthCareCategoryId == subCategoryId).ToListAsync();

        public async Task Update(Doctor entity)
        {
            dbContext.Doctors.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
