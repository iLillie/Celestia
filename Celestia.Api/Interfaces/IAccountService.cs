using Celestia.Models.DTO;

namespace Celestia.Api.Interfaces;

public interface IAccountService
{
    Task<AccountDto?> GetAsync(int id);
}