using Celestia.Models.Dto;

namespace Celestia.Api.Interfaces;

public interface IAccountService
{
    Task<AccountDto?> GetAsync(int id);
    Task<IEnumerable<AccountDto>> ListAsync();
}