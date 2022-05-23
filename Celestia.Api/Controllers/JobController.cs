using AutoMapper;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Job;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/job")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly GenericService<Job, IRepository<Job>> _jobService;
    private readonly IMapper _mapper;

    public JobController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _jobService = new GenericService<Job, IRepository<Job>>(unitOfWork.JobRepository, unitOfWork);
    }
    
    // GET: api/job
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobResultDto>>> GetAll()
    {
        var jobList = await _jobService.GetAllAsync();
        if (!jobList.Any())
            return NotFound("No jobs found");
        
        return Ok(_mapper.Map<IEnumerable<JobResultDto>>(jobList));
    }

    // GET: api/job/5
    [HttpGet("{id:int}", Name = "GetJobById")]
    public async Task<ActionResult<JobResultDto>> Get(int id)
    {
        var job = await _jobService.GetAsync(id);
        var jobNotFound = job is null;
        
        if (jobNotFound)
            return NotFound($"Job with id: {id} not found");
        
        return Ok(_mapper.Map<JobResultDto>(job));
    }

    // POST: api/job
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] JobAddDto? newJob)
    {
        var invalidJob = !ModelState.IsValid || newJob is null;
        
        if (invalidJob) 
            return BadRequest("Invalid model provided for a new job to be created");
        
        var job = await _jobService.AddAsync(_mapper.Map<Job>(newJob));
        return CreatedAtRoute(
            "GetJobById", 
            new { id = job.Id }, 
            _mapper.Map<JobResultDto>(job)
            );
    }

    // PUT: api/job/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, [FromBody] JobEditDto jobEditDto)
    {
        var invalidJob = !ModelState.IsValid && id != jobEditDto.Id;
        
        if (invalidJob) 
            return BadRequest("Invalid model provided for a job to be edited");
        
        var job = await _jobService.GetAsync(id);
        var jobNotFound = job is null;
        
        if (jobNotFound)
            return NotFound($"Job with id: {id} not found");
        
        await _jobService.UpdateAsync(id, _mapper.Map(jobEditDto, job)!);
        return NoContent();
    }
    
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var job = await _jobService.GetAsync(id);
        var jobNotFound = job is null;
        
        if(jobNotFound)
            return NotFound($"Job with id: {id} not found");
        
        await _jobService.Delete(job!);
        return NoContent();
    }
}