using UniverseModeTracker.Application.DTOs.Brand;

namespace UniverseModeTracker.Application.Services.Interfaces;

public interface IBrandService
{
    Task<BrandCreateDTO> CreateBrandAsync(BrandCreateDTO dto);
}