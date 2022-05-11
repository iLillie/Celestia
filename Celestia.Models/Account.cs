namespace Celestia.Models;

public class Account
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Alias { get; set; }

    public List<Position> Positions { get; set; } = new();
    public List<AdvertPost> AdvertPosts { get; set; } = new();
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}