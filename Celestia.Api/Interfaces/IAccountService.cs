using Celestia.Models;

namespace Celestia.Api.Interfaces;

public interface IAccountService
{
    public Task<Account> Create(Account newAccount);
    public Task<Account> Get(Guid accountId);
}