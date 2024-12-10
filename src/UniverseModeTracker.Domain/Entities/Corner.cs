using UniverseModeTracker.Domain.Common;

namespace UniverseModeTracker.Domain.Entities;

public partial class Corner
{
    public bool IsWinner { get; set; }
}

public partial class Corner
{
    public ICollection<Competitor>? Competitors { get; set; }
    public Guid MatchId { get; set; }
    public Match? Match { get; set; }
}

public partial class Corner : IBaseEntity, IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string? LastModifiedBy { get; set; }
}