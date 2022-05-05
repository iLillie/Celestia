namespace Celestia.Models;

public class Position
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public PositionState State { get; set; }
    public DateTime Date { get; set; }

    public Guid AccountId { get; set; }
    public Account? Account { get; set; }
}