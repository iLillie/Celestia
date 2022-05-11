using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _applicationDbContext;
    
    public AccountService(ApplicationDbContext applicationDbContext)
    {
        this._applicationDbContext = applicationDbContext;
    }

    public async Task<Account> Create(Account newAccount)
    {
        await _applicationDbContext.AddAsync(newAccount);
        await _applicationDbContext.SaveChangesAsync();
        return newAccount;
    }
    
    public async Task<Account> Get(Ulid accountId)
    {
        return await _applicationDbContext.Accounts.Where(pos => pos.Id.Equals(accountId)).FirstAsync();
    }
}