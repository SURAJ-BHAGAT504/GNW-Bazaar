using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface ISubCategoryMasterService
    {
        Task<ResponseDto<List<SubCategoryMasterDto>>> Get();
        Task<ResponseDto<SubCategoryMasterDto?>> Get(long id);
        Task<ResponseDto<List<SubCategoryMasterDto>>> GetByMasterCategory(long id);
        Task<ResponseDto<long>> Create(SubCategoryMasterDto entity);
        Task<ResponseDto<bool>> Update(SubCategoryMasterDto entity);
    }
}
