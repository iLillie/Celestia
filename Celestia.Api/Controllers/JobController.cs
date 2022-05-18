using Celestia.Api.Interfaces;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }
    
    // GET: api/Job
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobDto>>> Get()
    {
        return Ok(await _jobService.GetAllAsync());
    }

    // GET: api/Job/5
    [HttpGet("{id}", Name = "Get")]
    public async Task<ActionResult<JobDto>> Get(int id)
    {
        return await _jobService.GetAsync(id) ?? throw new InvalidOperationException();
    }

    // POST: api/Job
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] JobDto? value)
    {
        if (value is null) return BadRequest("Job is empty");

        var jobBoard = await _jobService.AddAsync(value);
        return CreatedAtRoute("Get", new { id = jobBoard.Id }, new JobDto(jobBoard));
    }

    // PUT: api/Job/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] JobDto value)
    {
        await _jobService.UpdateAsync(id, value);
        return NoContent();
    }

    // DELETE: api/Job/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}