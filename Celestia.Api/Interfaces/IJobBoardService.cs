using Celestia.Models;
using Celestia.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Interfaces;

public interface IJobBoardService
{
    Task<JobBoardDTO?> GetAsync(int id); 
    Task<IEnumerable<JobBoardDTO>> ListAsync();
    Task<IActionResult> AddJob(Job job);
}