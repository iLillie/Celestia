using Celestia.Models;
using Celestia.Models.Abstractions;

namespace Celestia.Api.Interfaces;

public interface IGenericService<T> 
    where T : OwnedModel
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetAsync(int id);
    Task<T> AddAsync(T value);
    Task<bool> Delete(int id);
    Task<bool> UpdateAsync(int id, T value);
}