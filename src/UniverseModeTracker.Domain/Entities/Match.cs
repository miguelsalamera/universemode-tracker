using Microsoft.Extensions.Logging;
using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Match
{
    public int Order { get; set; }
}

public partial class Match
{
    public Guid ShowId { get; set; }
    public Show? Show { get; set; }

    public ICollection<Corner>? Corners { get; set; }
    
}

public partial class Match : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? LastModifiedBy { get; set; }
}