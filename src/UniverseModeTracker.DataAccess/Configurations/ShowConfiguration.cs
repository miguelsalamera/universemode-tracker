using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class ShowConfiguration : IEntityTypeConfiguration<Show>
{
    private readonly BaseEntityConfiguration<Show> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Show> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Show> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);

        builder.HasMany(show => show.Matches)
            .WithOne(match => match.Show)
            .HasForeignKey(match => match.ShowId);
    }
}