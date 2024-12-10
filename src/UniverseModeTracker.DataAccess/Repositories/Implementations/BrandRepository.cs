using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class BrandRepository : Repository<Brand>, IBrandRepository
{
    public BrandRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}