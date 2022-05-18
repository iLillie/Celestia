using Celestia.Models;

namespace Celestia.Api.Interfaces;

public interface IJobService
{
    Task<IEnumerable<Job>> GetAllAsync();
    Task<Job?> GetAsync(int id);
    Task<Job> AddAsync(Job value);
    Task<bool> Delete(int id);
    Task<bool> UpdateAsync(int id, Job value);
}