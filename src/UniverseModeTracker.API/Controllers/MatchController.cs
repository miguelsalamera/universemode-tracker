using Microsoft.AspNetCore.Mvc;
using UniverseModeTracker.Application.DTOs.Match;
using UniverseModeTracker.Application.Interfaces;

namespace UniverseModeTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MatchController : ControllerBase
{
    private readonly IMatchService _matchService;

    public MatchController(IMatchService matchService)
    {
        _matchService = matchService;
    }

    [HttpPost("new")]
    public async Task<IActionResult> CreateMatch(MatchCreateDTO dto)
    {
        var match = await _matchService.CreateMatchAsync(dto);
        return Ok(match);
    }
}