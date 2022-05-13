using Celestia.Models;
using Celestia.Models.DTO;

namespace Celestia.Api.Interfaces;

public interface IAccountService
{
    Task<AccountDTO?> GetAsync(int id); 
}