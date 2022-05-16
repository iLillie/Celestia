using Celestia.Api.Interfaces;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/jobBoard")]
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

    [HttpGet("{id}", Name = "Get")]
    public async Task<ActionResult<JobBoardDto>> Get(int id)
    {
        var account = await _jobBoardService.GetAsync(id);
        if (account == null) return NotFound();
        return Ok(account);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] JobBoardCreationDto? creationDto)
    {
        if (creationDto is null)
        {
            return BadRequest("Job board object is empty");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        var jobBoard = await _jobBoardService.Create(creationDto);
        return CreatedAtRoute("Get", new { id = jobBoard.Id }, new JobBoardDto(jobBoard));
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] JobBoardUpdateDto? updateDto)
    {
        if (updateDto is null)
        {
            return BadRequest("Job board object is empty");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        var jobBoard = await _jobBoardService.Update(id, updateDto);
        return NoContent();
    }
}