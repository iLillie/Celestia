using Celestia.Models;
using Celestia.Models.Abstractions;

namespace Celestia.Api.Interfaces;

public interface IGenericService<T> 
    where T : OwnedModel
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetAsync(int id, string auth0Id);
    Task<T> AddAsync(T value);
    Task<bool> Delete(T value);
    Task<bool> UpdateAsync(int id, T value);
}