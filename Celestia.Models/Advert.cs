namespace Celestia.Models;

public class Advert
{
    public Guid Id { get; set; }
    public Guid Title { get; set; }
    public DateTime Deadline { get; set; }
    public string? Description { get; set; }
    
    public Guid ContactId { get; set; }
    public Contact? Contact { get; set; }
}