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

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var brands = await _brandService.GetAllBrandsAsync();
        return Ok(brands);
    }

    [HttpPost("new")]
    public async Task<IActionResult> CreateBrand(BrandCreateDTO dto)
    {
        var brand = await _brandService.CreateBrandAsync(dto);
        return Ok(brand);
    }
}