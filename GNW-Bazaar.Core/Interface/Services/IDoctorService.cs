using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IDoctorService
    {
        Task<ResponseDto<List<DoctorDto>>> Get();
        Task<ResponseDto<List<DoctorDto>>> GetDoctorBySubCategoryId(long subCategoryId);
        Task<ResponseDto<DoctorDto?>> Get(long id);
        Task<ResponseDto<long>> Create(DoctorDto entity);
        Task<ResponseDto<bool>> Update(DoctorDto entity);
    }
}
