using UniverseModeTracker.Application.DTOs.Competitor;

namespace UniverseModeTracker.Application.DTOs.Corner;

public class CornerCreateDTO
{
    public List<CompetitorCreateDTO> Competitors { get; set; }
}