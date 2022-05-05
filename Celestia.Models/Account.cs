namespace Celestia.Models;

public class Account
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Alias { get; set; }

    public ICollection<Position>? Positions { get; set; }
}