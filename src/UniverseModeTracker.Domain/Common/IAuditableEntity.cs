namespace UniverseModeTracker.Domain.Common;

public interface IAuditableEntity
{
    DateTime CreatedDate { get; set; }
    DateTime? LastModifiedDate { get; set; }
    string CreatedBy { get; set; }
    string? LastModifiedBy { get; set; }
}