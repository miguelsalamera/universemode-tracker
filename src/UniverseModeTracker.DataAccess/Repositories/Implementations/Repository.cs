using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DefaultDataContext _defaultDataContext;

    public Repository(DefaultDataContext defaultDataContext)
    {
        _defaultDataContext = defaultDataContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _defaultDataContext.Set<T>().AddAsync(entity);
        await _defaultDataContext.SaveChangesAsync();

        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _defaultDataContext.Set<T>().Update(entity);
        await _defaultDataContext.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _defaultDataContext.Set<T>().FindAsync(id);
        if (entity == null) return false;

        _defaultDataContext.Set<T>().Remove(entity);
        await _defaultDataContext.SaveChangesAsync();
        return true;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _defaultDataContext.Set<T>().FindAsync(id);
    }
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _defaultDataContext.Set<T>().ToListAsync();
    }
}