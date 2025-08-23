namespace GNW_Bazaar.Core.Interface.Clients
{
    public interface IMasterDataClient<T>
    {
        Task<List<T>> Get();
        Task<T?> Get(long id);
        Task<long> Create(T entity);
        Task Update(T entity);
    }
}
