using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace UniverseModeTracker.DataAccess.Persistence.Context;

public class DefaultDataContext : DbContext
{
    public DefaultDataContext(DbContextOptions<DefaultDataContext> options) : base(options) {}
    
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Competitor> Competitors { get; set; }
    public DbSet<Corner> Corners { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Show> Shows { get; set; }
    public DbSet<Superstar> Superstars { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompetitorConfiguration());
        modelBuilder.ApplyConfiguration(new CornerConfiguration());
        modelBuilder.ApplyConfiguration(new MatchConfiguration());
        modelBuilder.ApplyConfiguration(new ShowConfiguration());
        modelBuilder.ApplyConfiguration(new SuperstarConfiguration());
    }
}