namespace Celestia.Models.Abstractions;

public abstract class BaseModel
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}