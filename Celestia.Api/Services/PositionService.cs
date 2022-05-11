using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class PositionService : IPositionService
{
    private readonly ApplicationDbContext _applicationDbContext;
    
    public PositionService(ApplicationDbContext applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
    }

    public async Task<IEnumerable<Position>> All(Guid accountId)
    {
        return await _applicationDbContext.Positions.Where(pos => pos.AccountId.Equals(accountId)).ToListAsync();
    }

    public async Task<Position> Get(Guid positionId, Guid accountId)
    {
        return await _applicationDbContext.Positions.Where(pos => pos.AccountId.Equals(accountId))
            .Where(pos => pos.Id == positionId)
            .FirstAsync();
    }
}