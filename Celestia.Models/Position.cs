using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Position : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Offer { get; set; }
    public PositionState State { get; set; }
    public DateTime Deadline { get; set; }
    
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }

    
    
    public enum PositionState
    {
        Todo,
        Progress,
        Completed,
        Offer,
        Denied,
        Archived
    }
}