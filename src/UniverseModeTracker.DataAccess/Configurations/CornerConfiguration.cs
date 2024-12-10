using UniverseModeTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniverseModeTracker.DataAccess.Configurations;

public class CornerConfiguration : IEntityTypeConfiguration<Corner>
{
    private readonly BaseEntityConfiguration<Corner> _baseConfiguration = new();
    private readonly AuditableEntityConfiguration<Corner> _auditConfiguration = new();
    public void Configure(EntityTypeBuilder<Corner> builder)
    {
        _baseConfiguration.Configure(builder);
        _auditConfiguration.Configure(builder);
    }
}