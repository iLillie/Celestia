using Celestia.Models.Utilities;

namespace Celestia.Models.Dto;

public class AccountDto
{
    private readonly string _alias;
    private readonly string _lastName;
    private readonly string _name;

    public AccountDto(Account account)
    {
        AliasPreferred = account.AliasPreferred;
        _alias = account.Alias ?? string.Empty;
        _lastName = account.LastName ?? string.Empty;
        Email = account.Email;
        _name = account.Name;
        Id = account.Id;
    }

    public int Id { get; }
    public string Name => AliasPreferred ? _alias : _name;
    public string FullName => AliasPreferred ? _alias : $"{_name} {_lastName}".TrimEnd();
    public string Email { get; }
    public bool AliasPreferred { get; }
}