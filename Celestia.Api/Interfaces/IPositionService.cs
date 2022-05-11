using Celestia.Models;

namespace Celestia.Api.Interfaces;

public interface IPositionService
{
    public Task<IEnumerable<Position>> All(Guid accountId);

    public Task<Position> Get(Guid positionId, Guid accountId);
}