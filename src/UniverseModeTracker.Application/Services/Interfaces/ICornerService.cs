using UniverseModeTracker.Application.DTOs.Corner;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface ICornerService
{
    Task<CornerCreateDTO> CreateCornerAsync(CornerCreateDTO dto);
}