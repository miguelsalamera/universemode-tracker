using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class CompetitorRepository : Repository<Competitor>, ICompetitorRepository
{
    public CompetitorRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}