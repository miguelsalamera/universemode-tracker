using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniverseModeTracker.Application.DTOs.Superstar;
using UniverseModeTracker.Application.Interfaces;

namespace UniverseModeTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuperstarController : ControllerBase
{
    private readonly ISuperstarService _superstarService;

    public SuperstarController(ISuperstarService superstarService)
    {
        _superstarService = superstarService;
    }

    [HttpPost("new")]
    public async Task<IActionResult> CreateSuperstar(SuperstarCreateDTO dto)
    {
        var createdSuperstar = await _superstarService.CreateSuperstarAsync(dto);
        return Ok(createdSuperstar);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetSuperstarByIdAsync([FromRoute] Guid id)
    {
        Console.WriteLine(id);
        var superstar = await _superstarService.GetSuperstarByIdAsync(id);
        return Ok(superstar); 
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var superstars = await _superstarService.GetAllSuperstarsAsync();
        return Ok(superstars); // Return a list of all products
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] SuperstarUpdateDTO dto)
    {
        try
        {
            await _superstarService.UpdateSuperstarAsync(id, dto);
            return NoContent(); // Return 204 No Content after successful update
        }
        catch (KeyNotFoundException)
        {
            return NotFound(); // Return 404 if the product is not found
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _superstarService.DeleteSuperstarAsync(id);
            return NoContent(); // Return 204 No Content after successful deletion
        }
        catch (KeyNotFoundException)
        {
            return NotFound(); // Return 404 if the product is not found
        }
    }
}