using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dtos.Job;

public class JobAddDto
{
    [Required(ErrorMessage = "The field {0} is required")]
    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public string? PostingUrl { get; set; }
    
    public string? Address { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required")]
    public string Status { get; set; } = JobStatus.Draft.ToString();
}