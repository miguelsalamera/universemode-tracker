using Microsoft.EntityFrameworkCore;

namespace UniverseModeTracker.DataAccess.Persistence.Context;

public class DefaultDataContext : DbContext
{
    public DefaultDataContext(DbContextOptions<DefaultDataContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}