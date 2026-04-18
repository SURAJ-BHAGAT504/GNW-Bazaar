using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface ISponsorService
    {
        Task<ResponseDto<List<SponsorDto>>> Get();
        Task<ResponseDto<List<SponsorDto>>> GetByAdmin();
        Task<ResponseDto<SponsorDto?>> Get(long id);
        Task<ResponseDto<List<SponsorDto>>> GetSponsorsByCategoryMaster(long categoryMasterId);
        Task<ResponseDto<long>> Create(SponsorDto entity, string rootPath);
        Task<ResponseDto<bool>> Update(SponsorDto entity, string rootPath);

        //Task<ResponseDto<List<SponsorDto>>> GetByEmail(string email);
        //Task<ResponseDto<bool>> RecordFrequency(long sponsorId);
    }
}
