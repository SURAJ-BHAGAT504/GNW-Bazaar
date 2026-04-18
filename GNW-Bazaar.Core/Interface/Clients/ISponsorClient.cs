using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface ISponsorClient
    {
        Task<List<Sponsor>> Get();
        Task<Sponsor?> Get(long id);
        Task<List<Sponsor>> GetSponsorsByMasterCategory(long categoryMasterId);
        Task<long> Create(Sponsor entity);
        Task Update(Sponsor entity);
    }
}
