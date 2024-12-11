using UniverseModeTracker.Application.DTOs.Competitor;

namespace UniverseModeTracker.Application.Interfaces;

public interface ICompetitorService
{
    Task<CompetitorCreateDTO> CreateCompetitorAsync(CompetitorCreateDTO dto);
}
