using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;


public class JobService : IJobService
{
    private readonly ApplicationDbContext _context;
    
    public JobService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<JobDto?> GetAsync(int id)
    {
        var job = await _context.Jobs.FindAsync(id);

        return job is null ? null : new JobDto(job);
    }

    public async Task<IEnumerable<JobDto>> ListAsync()
    {
        var jobs = await _context.Jobs.ToListAsync();

        return jobs.Select(j => new JobDto(j));
    }

    public async Task<Job> Create(JobCreationDto creationDto)
    {
        var job = new Job(creationDto);
        await _context.Jobs.AddAsync(job);
        await _context.SaveChangesAsync();
        return job;
    }
    
    public async Task<Job?> Update(int id, JobUpdateDto updateDto)
    {
        var job = await _context.Jobs.FindAsync(id);
        if (job is null) return null;

        job.Update(updateDto);
        _context.Jobs.Update(job);
        await _context.SaveChangesAsync();
        return job;
    }
}