using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _context;

    public AccountService(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<AccountDTO?> GetAsync(int id)
    {
        Account? account = await _context.Accounts
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        if (account is null) return null;
        var accountDto = new AccountDTO(account);
        return accountDto;
    }
}