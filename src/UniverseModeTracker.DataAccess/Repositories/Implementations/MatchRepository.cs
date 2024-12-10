using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class MatchRepository : Repository<Match>, IMatchRepository
{
    public MatchRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}