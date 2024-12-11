using UniverseModeTracker.Application.DTOs.Competitor;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface ICompetitorService
{
    Task<CompetitorCreateDTO> CreateCompetitorAsync(CompetitorCreateDTO dto);
}
