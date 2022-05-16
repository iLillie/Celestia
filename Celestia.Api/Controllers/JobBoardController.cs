using Celestia.Api.Interfaces;
using Celestia.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class JobBoardController : ControllerBase
{
    private readonly IJobBoardService _jobBoardService;

    public JobBoardController(IJobBoardService jobBoardService)
    {
        _jobBoardService = jobBoardService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobBoardDto>>> Get()
    {
        var jobs = await _jobBoardService.ListAsync();
        if (!jobs.Any()) return NotFound();
        return Ok(jobs);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<JobBoardDto>> Get(int id)
    {
        var account = await _jobBoardService.GetAsync(id);
        if (account == null) return NotFound();
        return Ok(account);
    }
}