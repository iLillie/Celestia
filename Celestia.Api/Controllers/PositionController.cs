using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;
[ApiController]
[Route("api/position")]
public class PositionController : ControllerBase
{
    private readonly IPositionService _positionService;
    
    public PositionController(IPositionService positionService)
    {
        this._positionService = positionService;
    }
    
    [HttpGet("all/{accountId}")]
    public async Task<IEnumerable<Position>> All(Guid accountId)
    {
        return await _positionService.All(accountId);
    }

    [HttpGet("{id}/{accountId}")]
    public async Task<Position> Get(Guid id, Guid accountId)
    {
        return await _positionService.Get(id, accountId);
    }
}