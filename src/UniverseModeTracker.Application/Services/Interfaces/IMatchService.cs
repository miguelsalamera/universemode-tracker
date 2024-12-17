using UniverseModeTracker.Application.DTOs.Match;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface IMatchService
{
    Task<bool> CreateMatchAsync(MatchCreateDTO dto);
}