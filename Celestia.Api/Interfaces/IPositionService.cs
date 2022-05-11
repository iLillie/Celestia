using Celestia.Models;

namespace Celestia.Api.Interfaces;

public interface IPositionService
{
    public Task<IEnumerable<Position>> All(Ulid accountId);

    public Task<Position> Get(Ulid positionId, Ulid accountId);
}