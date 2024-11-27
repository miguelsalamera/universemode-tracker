using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Superstar : IBaseEntity, IAuditableEntity
{
    public string RingName { get; set; }
    public int WinCount { get; set; }
    public int LossCount { get; set; }
    public int NoContestCount { get; set; }
}

public partial class Superstar : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; }
    public string? LastModifiedBy { get; set; }
}