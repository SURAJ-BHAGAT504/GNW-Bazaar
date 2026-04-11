using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface ISubCategoryMasterClient
    {
        Task<List<SubCategoryMaster>> Get();
        Task<SubCategoryMaster?> Get(long id);
        Task<List<SubCategoryMaster>> GetByMasterCategory(long id);
        Task<long> Create(SubCategoryMaster entity);
        Task Update(SubCategoryMaster entity);
    }
}
