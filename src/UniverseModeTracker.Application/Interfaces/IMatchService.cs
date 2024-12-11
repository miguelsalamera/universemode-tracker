using UniverseModeTracker.Application.DTOs.Match;


namespace UniverseModeTracker.Application.Interfaces;

public interface IMatchService
{
    Task<MatchCreateDTO> CreateMatchAsync(MatchCreateDTO dto);
}