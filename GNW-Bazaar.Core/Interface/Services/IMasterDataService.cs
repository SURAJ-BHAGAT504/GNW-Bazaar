using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IMasterDataService<T>
    {
        Task<ResponseDto<List<T>>> Get();
        Task<ResponseDto<T>> Get(long id);
        Task<ResponseDto<long>> Create(T entity);
        Task<ResponseDto<T>> Update(T entity);
    }
}
