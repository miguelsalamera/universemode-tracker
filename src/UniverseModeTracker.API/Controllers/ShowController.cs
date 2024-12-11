using Microsoft.AspNetCore.Mvc;
using UniverseModeTracker.Application.DTOs.Match;
using UniverseModeTracker.Application.Services.Interfaces;

namespace UniverseModeTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowController : ControllerBase
{
    private readonly IShowService _showService;

    public ShowController(IShowService showService)
    {
        _showService = showService;
    }

    [HttpPost("new")]
    public async Task<IActionResult> CreateMatch(ShowCreateDTO dto)
    {
        var show = await _showService.CreateShowAsync(dto);
        return Ok(show);
    }
}