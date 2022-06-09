using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _dbContext;
    
    public AccountService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Account?> GetUserFromAuth0Id(string auth0Id)
        => await _dbContext.Accounts.FirstOrDefaultAsync(account => account.Auth0Id == auth0Id);

}