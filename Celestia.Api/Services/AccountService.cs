using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _context;

    public AccountService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AccountDto?> GetAsync(int id)
    {
        var account = await _context.Accounts.FindAsync(id);
        return account is null ? null : new AccountDto(account);
    }
    
    public async Task<IEnumerable<AccountDto>> ListAsync()
    {
        var accounts = await _context.Accounts
            .ToListAsync();

        return accounts.Select(a => new AccountDto(a));
    }
}