using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class JobBoardService : IJobBoardService
{
    private readonly ApplicationDbContext _context;

    public JobBoardService(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<JobBoardDTO?> GetAsync(int id)
    {
        
        JobBoard? jobBoard = await _context.JobBoards
            .Where(j => j.Id == id)
            .Include(j => j.Jobs)
            .FirstOrDefaultAsync();
        if (jobBoard is null) return null;
        var accountDto = new JobBoardDTO(jobBoard);
        return accountDto;
    }

    public Task<IEnumerable<JobBoardDTO>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> AddJob(Job job)
    {
        throw new NotImplementedException();
    }
}