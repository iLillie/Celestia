using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class JobBoardService : IJobBoardService
{
    private readonly ApplicationDbContext _context;

    public JobBoardService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<JobBoardDto?> GetAsync(int id)
    {
        var jobBoard = await _context.JobBoards
            .Include(j => j.Jobs)
            .FirstOrDefaultAsync(j => j.Id == id);

        return jobBoard is null ? null : new JobBoardDto(jobBoard);
    }

    public async Task<IEnumerable<JobBoardDto>> ListAsync()
    {
        var jobBoards = await _context.JobBoards
            .Include(j => j.Jobs)
            .ToListAsync();

        return jobBoards.Select(jB => new JobBoardDto(jB));
    }

    public async Task<JobBoard> Create(JobBoardCreationDto creationDto)
    {
        var jobBoard = new JobBoard(creationDto);
        await _context.JobBoards.AddAsync(jobBoard);
        await _context.SaveChangesAsync();
        return jobBoard;
    }

    public async Task<JobBoard?> Update(int id, JobBoardUpdateDto updateDto)
    {
        var jobBoard = await _context.JobBoards.FindAsync(id);
        if (jobBoard is null) return null;
        
        jobBoard.Update(updateDto);
        _context.JobBoards.Update(jobBoard);
        await _context.SaveChangesAsync();
        
        return jobBoard;
    }
}