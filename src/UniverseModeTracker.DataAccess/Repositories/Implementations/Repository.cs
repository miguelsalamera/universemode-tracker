using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

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

}