using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Show
{
    public int Week { get; set; }
    public string Month { get; set; }
}

public partial class Show
{
    public Guid BrandId { get; set; }
    public Brand Brand { get; set; }
    public ICollection<Match>? Matches { get; set; }
}

public partial class Show : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? LastModifiedBy { get; set; }
}