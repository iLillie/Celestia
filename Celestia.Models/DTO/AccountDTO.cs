namespace Celestia.Models.DTO;

public class AccountDTO
{
    private readonly bool _aliasPreferred;
    private readonly string _alias;
    private readonly int _id;
    private readonly string _name;
    private readonly string _lastName;
    private readonly string _email;

    public AccountDTO(Account account)
    {
        _aliasPreferred = account.AliasPreferred;
        _alias = string.IsNullOrEmpty(account.Alias) ? "" : account.Alias;
        _lastName = string.IsNullOrEmpty(account.LastName) ? "" : account.LastName;
        _email = account.Email;
        _name = account.Name;
        _id = account.Id;
    }

    public int Id => _id;
    public string Name => _aliasPreferred ? _alias : _name;
    public string FullName => _aliasPreferred ? _alias : $"{_name} {_lastName}".TrimEnd();
    public string Email => _email;
}