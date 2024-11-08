namespace UniverseModeTracker.Domain.Common;

public interface IAuditableEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string CreatedBy { get; set; }
    public string? LastModifiedBy { get; set; }
}