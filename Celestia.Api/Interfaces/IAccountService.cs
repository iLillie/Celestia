using Celestia.Models;

namespace Celestia.Api.Interfaces;

public interface IAccountService
{
    public Task<Account?> GetUserFromAuth0Id(string auth0Id);
}