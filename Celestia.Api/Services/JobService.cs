using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;



public class JobService : IJobService
{
    private readonly ApplicationDbContext _dbContext;

    public JobService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<JobDto>> GetAllAsync()
    {
        return await _dbContext.Jobs.Select(j => new JobDto(j)).ToListAsync();;
    }

    public async Task<JobDto?> GetAsync(int id)
    {
        var job = await _dbContext.Jobs.FindAsync(id);

        if (job is null) return null;
        
        return new JobDto(job);
    }

    public async Task<Job> AddAsync(JobDto jobDto)
    {
        var job = Job.MapDto(jobDto);
        await _dbContext.Jobs.AddAsync(job);
        await _dbContext.SaveChangesAsync();
        return job;
    }
    public void Remove() {}

    public async Task UpdateAsync(int id, JobDto jobDto)
    { 
        var job = await _dbContext.Jobs.FirstAsync(j => j.Id == id);
        job.Update(jobDto);
        _dbContext.Jobs.Update(job);
        await _dbContext.SaveChangesAsync();
    }
}