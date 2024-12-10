using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Competitor
{
    public bool IsManager { get; set; }
    public bool IsPinfallScorer { get; set; }
    public bool IsPinned { get; set; }
}

public partial class Competitor
{
    public Guid SuperstarId { get; set; }
    public Superstar? Superstar { get; set; }

    public Guid CornerId { get; set; }
    public Corner? Corner { get; set; }
}

public partial class Competitor : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? LastModifiedBy { get; set; }
}