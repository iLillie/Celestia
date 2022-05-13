using Celestia.Api.Interfaces;
using Celestia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class JobBoardController : ControllerBase
{
    private readonly IJobBoardService _jobBoardService;

    public JobBoardController(IJobBoardService jobBoardService)
    {
        this._jobBoardService = jobBoardService;
    }
    [HttpGet]
    public string Get()
    {
        return "API Test";
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var account = await _jobBoardService.GetAsync(id);
        if (account == null) return NotFound();
        return Ok(account);
    }
}