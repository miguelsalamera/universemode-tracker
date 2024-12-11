using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class CompetitorConfiguration : IEntityTypeConfiguration<Competitor>
{
    private readonly BaseEntityConfiguration<Competitor> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Competitor> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Competitor> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);

        builder.HasKey(competitor => new { competitor.SuperstarId, competitor.CornerId });

        builder.HasOne(competitor => competitor.Superstar)
            .WithMany(superstar => superstar.Competitors)
            .HasForeignKey(competitor => competitor.SuperstarId);

        builder.HasOne(competitor => competitor.Corner)
            .WithMany(corner => corner.Competitors)
            .HasForeignKey(competitor => competitor.CornerId);
    }
}

