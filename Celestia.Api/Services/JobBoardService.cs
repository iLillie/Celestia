using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.DTO;
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

        var accountDto = new JobBoardDto(jobBoard);

        return accountDto;
    }

    public async Task<IEnumerable<JobBoardDto>> ListAsync()
    {
        var jobBoards = await _context.JobBoards
            .Include(j => j.Jobs).ToListAsync();

        return jobBoards.Select(jB => new JobBoardDto(jB));
    }


    public Task AddJob(Job job)
    {
        throw new NotImplementedException();
    }
}