using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class MatchConfiguration : IEntityTypeConfiguration<Match>
{
    private readonly BaseEntityConfiguration<Match> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Match> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Match> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);
        
        builder.Property(property => property.Order)
            .IsRequired();

        builder.HasMany(match => match.Corners)
            .WithOne(corner => corner.Match)
            .HasForeignKey(corner => corner.MatchId);
    }
}