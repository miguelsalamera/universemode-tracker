using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class SuperstarConfiguration : IEntityTypeConfiguration<Superstar>
{
    private readonly BaseEntityConfiguration<Superstar> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Superstar> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Superstar> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);

        builder.Property(property => property.RingName)
            .IsRequired()
            .HasMaxLength(250);
    }
}