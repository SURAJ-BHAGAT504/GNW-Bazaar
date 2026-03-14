using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface IDoctorClient
    {
        Task<List<Doctor>> Get();
        Task<List<Doctor>> GetDoctorByCategoryId(long subCategoryId);
        Task<Doctor?> Get(long id);
        Task<long> Create(Doctor entity);
        Task Update(Doctor entity);
    }
}
