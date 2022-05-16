using Celestia.Models;
using Celestia.Models.Dto;

namespace Celestia.Api.Interfaces;

public interface IJobService
{
    Task<JobDto?> GetAsync(int id);
    Task<IEnumerable<JobDto>> ListAsync();
    Task<Job> Create(JobCreationDto creationDto);
    Task<Job?> Update(int id, JobUpdateDto updateDto);
}