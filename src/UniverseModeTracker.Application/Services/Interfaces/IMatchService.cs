using UniverseModeTracker.Application.DTOs.Match;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface IMatchService
{
    Task<MatchCreateDTO> CreateMatchAsync(MatchCreateDTO dto);
}