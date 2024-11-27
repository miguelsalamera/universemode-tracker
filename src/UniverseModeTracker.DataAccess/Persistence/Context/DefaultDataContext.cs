using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace UniverseModeTracker.DataAccess.Persistence.Context;

public class DefaultDataContext : DbContext
{
    public DefaultDataContext(DbContextOptions<DefaultDataContext> options) : base(options) {}

    public DbSet<Superstar> Superstars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SuperstarConfiguration());
    }
}