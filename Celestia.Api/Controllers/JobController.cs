using AutoMapper;
using Celestia.Api.Interfaces;
using Celestia.Models;
using Celestia.Models.Dtos.Job;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;
    private readonly IMapper _mapper;

    public JobController(IMapper mapper, IJobService jobService)
    {
        _mapper = mapper;
        _jobService = jobService;
    }
    
    // GET: api/Job
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobResultDto>>> GetAll()
    {
        var jobs = await _jobService.GetAllAsync();
        var jobResultDtos = _mapper.Map<IEnumerable<JobResultDto>>(jobs);
        return Ok(jobResultDtos);
    }

    // GET: api/Job/5
    [HttpGet("{id}", Name = "GetJobById")]
    public async Task<ActionResult<JobResultDto>> Get(int id)
    {
        var job = await _jobService.GetAsync(id);
        
        if (job == null) return NotFound();

        var jobResultDto = _mapper.Map<JobResultDto>(job);
        return Ok(jobResultDto);
    }

    // POST: api/Job
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post([FromBody] JobAddDto? value)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (value is null) return BadRequest("Job is empty");
        
        var job = _mapper.Map<Job>(value);
        var jobResult = await _jobService.AddAsync(job);
        var jobResultDto =  _mapper.Map<JobResultDto>(job);
        return CreatedAtRoute("GetJobById", new { id = jobResult.Id }, jobResultDto);
    }

    // PUT: api/Job/5
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] JobEditDto value)
    {
        if (id != value.Id) return BadRequest();
        var fetchedJob = await _jobService.GetAsync(id);
        
        if (fetchedJob is null) return NotFound();

        if (!ModelState.IsValid) return BadRequest();
        
        
        var mappedJob = _mapper.Map(value, fetchedJob);
        
        var isEdited = await _jobService.UpdateAsync(id, mappedJob);
        
        if (!isEdited) return BadRequest();
        
        return NoContent();
    }
    
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(int id)
    {
        var isDeleted = await _jobService.Delete(id);
        return isDeleted ? NoContent() : NotFound();
    }
}