using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class CornerRepository : Repository<Corner>, ICornerRepository
{
    public CornerRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}