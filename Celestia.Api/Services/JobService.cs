using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;

namespace Celestia.Api.Services;



public class JobService : IJobService
{
    private readonly IUnitOfWork _unitOfWork;

    public JobService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Job>> GetAllAsync() 
        => await _unitOfWork.JobRepository.GetAllAsync();

    public async Task<Job?> GetAsync(int id)
        => await _unitOfWork.JobRepository.GetAsync(id);

    public async Task<Job> AddAsync(Job value)
    {
        value.Id = 0;
        await _unitOfWork.JobRepository.AddAsync(value);
        await _unitOfWork.Complete();
        return value;
    }

    public async Task<bool> Delete(int id)
    {
        var job = await _unitOfWork.JobRepository.GetAsync(id);
        if (job is null) return false;
        _unitOfWork.JobRepository.Delete(job);
        return await _unitOfWork.Complete();
    }

    public async Task<bool> UpdateAsync(int id, Job value)
    {
        _unitOfWork.JobRepository.Update(value);
        
        return await _unitOfWork.Complete();
    }
}