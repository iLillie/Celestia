using Celestia.Api.Interfaces;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/job")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobDto>>> Get()
    {
        var jobs = await _jobService.ListAsync();
        if (!jobs.Any()) return NotFound();
        return Ok(jobs);
    }

    [HttpGet("{id}", Name = "GetJobById")]
    public async Task<ActionResult<JobDto>> Get(int id)
    {
        var account = await _jobService.GetAsync(id);
        if (account == null) return NotFound();
        return Ok(account);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] JobCreationDto? creationDto)
    {
        if (creationDto is null)
        {
            return BadRequest("Job board object is empty");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        var jobBoard = await _jobService.Create(creationDto);
        return CreatedAtRoute("GetJobById", new { id = jobBoard.Id }, new JobDto(jobBoard));
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] JobUpdateDto? updateDto)
    {
        if (updateDto is null)
        {
            return BadRequest("Job board object is empty");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        var jobBoard = await _jobService.Update(id, updateDto);
        return NoContent();
    }
}