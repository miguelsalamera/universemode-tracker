using UniverseModeTracker.Application.DTOs.Corner;

namespace UniverseModeTracker.Application.Interfaces;

public interface ICornerService
{
    Task<CornerCreateDTO> CreateCornerAsync(CornerCreateDTO dto);
}