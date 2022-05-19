using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dtos.Job;

public class JobEditDto
{
    [Required(ErrorMessage = "The field {0} is required")]
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    public string? PostingUrl { get; set; }
    
    public string? Address { get; set; }
    
    public string? Status { get; set; }
    
    public int? FolderId { get; set; }
}