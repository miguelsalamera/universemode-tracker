namespace UniverseModeTracker.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
}