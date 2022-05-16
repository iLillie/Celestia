using Celestia.Models;
using Celestia.Models.Dto;

namespace Celestia.Api.Interfaces;

public interface IJobBoardService
{
    Task<JobBoardDto?> GetAsync(int id);
    Task<IEnumerable<JobBoardDto>> ListAsync();
    public Task<JobBoard> Create(JobBoardCreationDto creationDto);
    public Task<JobBoard?> Update(int id, JobBoardUpdateDto updateDto);
}