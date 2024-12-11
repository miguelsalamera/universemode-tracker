namespace UniverseModeTracker.Application.DTOs.Competitor;

public class CompetitorCreateDTO
{
    public Guid CornerId { get; set; }
    public Guid SuperstarId { get; set; }
    public bool IsManager { get; set; }
    
}