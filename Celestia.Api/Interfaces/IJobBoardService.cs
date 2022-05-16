using Celestia.Models;
using Celestia.Models.DTO;

namespace Celestia.Api.Interfaces;

public interface IJobBoardService
{
    Task<JobBoardDto?> GetAsync(int id);
    Task<IEnumerable<JobBoardDto>> ListAsync();
    Task AddJob(Job job);
}