using UniverseModeTracker.DataAccess.Persistence.Context;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.DataAccess.Repositories.Implementations;

public class SuperstarRepository : Repository<Superstar>, ISuperstarRepository
{
    public SuperstarRepository(DefaultDataContext defaultDatacontext) : base(defaultDatacontext) { }
}