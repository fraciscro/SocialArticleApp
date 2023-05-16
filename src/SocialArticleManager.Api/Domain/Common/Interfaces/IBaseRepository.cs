namespace SocialArticleManager.Api.Domain.Common.Interfaces
{
    public interface IBaseRepository<T, TId> where T : class
    {
        Task<T> GetByIdAsync(TId id);
        Task<List<T>> GetAllAsync();
        Task<T> Update(T entity);
        Task DeleteAsync(T entity);
        Task<T> AddAsync(T entity);
    }
}
