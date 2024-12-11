using Microsoft.AspNetCore.Mvc;
using UniverseModeTracker.Application.DTOs.Brand;
using UniverseModeTracker.Application.Services.Interfaces;

namespace UniverseModeTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpPost("new")]
    public async Task<IActionResult> CreateBrand(BrandCreateDTO dto)
    {
        var match = await _brandService.CreateBrandAsync(dto);
        return Ok(match);
    }
}