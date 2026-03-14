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
            await dbContext.Doctors.Include(d => d.healthCareCategory).ToListAsync();

        public async Task<Doctor?> Get(long id) =>
            await dbContext.Doctors.Include(d => d.healthCareCategory).Where(d => d.Id == id).FirstOrDefaultAsync();

        public async Task<List<Doctor>> GetDoctorByCategoryId(long subCategoryId) =>
            await dbContext.Doctors.Include(d => d.healthCareCategory).Where(d => d.healthCareCategory.Any(c => c.Id == subCategoryId)).ToListAsync();

        public async Task Update(Doctor entity)
        {
            dbContext.Doctors.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
