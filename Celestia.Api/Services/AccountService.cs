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
        var account = await _context.Accounts
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        if (account is null) return null;
        var accountDto = new AccountDto(account);
        return accountDto;
    }
}