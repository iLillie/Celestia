using Celestia.Models;
using Celestia.Models.Dto;

namespace Celestia.Api.Interfaces;

public interface IJobService
{
    Task<IEnumerable<JobDto>> GetAllAsync();
    Task<JobDto?> GetAsync(int id);
    Task<Job> AddAsync(JobDto jobDto);
    void Remove();
    Task UpdateAsync(int id, JobDto jobDto);
}