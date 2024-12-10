using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    private readonly BaseEntityConfiguration<Brand> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Brand> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);

        builder.Property(property => property.Name)
            .IsRequired()
            .HasMaxLength(250);
    }
}