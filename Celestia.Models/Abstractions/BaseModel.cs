namespace Celestia.Models.Abstractions;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    
    public Account? Author { get; set; }
    public Guid AuthorId { get; set; }
    
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}