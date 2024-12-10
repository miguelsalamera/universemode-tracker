using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class ShowRepository : Repository<Show>, IShowRepository
{
    public ShowRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}