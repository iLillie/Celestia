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
            .Where(j => j.Id == id)
            .Include(j => j.Jobs)
            .FirstOrDefaultAsync();

        if (jobBoard is null) return null;

        var jobBoardDto = new JobBoardDto(jobBoard);

        return jobBoardDto;
    }

    public async Task<IEnumerable<JobBoardDto>> ListAsync()
    {
        var jobBoards = await _context.JobBoards
            .Include(j => j.Jobs).ToListAsync();

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
        var jobBoard = await _context.JobBoards.FirstOrDefaultAsync(j => j.Id == id);
        if (jobBoard is null) return null;
        jobBoard.Update(updateDto);
        _context.JobBoards.Update(jobBoard);
        await _context.SaveChangesAsync();
        return jobBoard;
    }
}