namespace Celestia.Models.Dtos.Job;

public class JobResultDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public string? PostingUrl { get; set; }
    
    public string? Address { get; set; }
    
    public string Status { get; set; } = null!;
}