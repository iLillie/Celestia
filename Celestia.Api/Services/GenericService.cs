﻿using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Abstractions;

namespace Celestia.Api.Services;



public class GenericService<T, TRepository> : IGenericService<T> 
    where T : OwnedModel, new()
    where TRepository : IRepository<T>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly TRepository _repository;

    public GenericService(TRepository repository, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
    }

    public async Task<IEnumerable<T>> GetAllAsync() 
        => await _repository.GetAllAsync();

    public async Task<T?> GetAsync(int id)
        => await _repository.GetAsync(id);

    public async Task<T> AddAsync(T value)
    {
        value.Id = 0;
        await _repository.AddAsync(value);
        await _unitOfWork.Complete();
        return value;
    }

    public async Task<bool> Delete(int id)
    {
        var job = await _repository.GetAsync(id);
        if (job is null) return false;
        _repository.Delete(job);
        return await _unitOfWork.Complete();
    }

    public async Task<bool> UpdateAsync(int id, T value)
    {
        _repository.Update(value);
        
        return await _unitOfWork.Complete();
    }
}