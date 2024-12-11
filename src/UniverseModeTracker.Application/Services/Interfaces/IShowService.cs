using UniverseModeTracker.Application.DTOs.Match;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface IShowService
{
    Task<ShowCreateDTO> CreateShowAsync(ShowCreateDTO dto);
}