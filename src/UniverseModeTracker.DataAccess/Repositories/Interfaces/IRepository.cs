namespace UniverseModeTracker.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T : class
{

    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(Guid id);
    Task SaveAsync();
}