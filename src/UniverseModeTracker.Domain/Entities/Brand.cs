using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Brand
{
    public string Name { get; set; }
}

public partial class Brand : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? LastModifiedBy { get; set; }
}