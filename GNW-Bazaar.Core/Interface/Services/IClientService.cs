using GNW_Bazzar.Dto;

namespace GNW_Bazaar.Core.Interface.Services
{
    public interface IClientService
    {
        Task<ResponseDto<List<ClientDto>>> Get();
        Task<ResponseDto<ClientDto?>> Get(long id);
        Task<ResponseDto<long>> Create(ClientDto entity, string rootPath);
        Task<ResponseDto<bool>> Update(ClientDto entity, string rootPath);
    }
}
