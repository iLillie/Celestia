using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("jobs")]
public class Job : OwnedModel
{
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(60, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "The field {0} is required")]
    public string Description { get; set; } = string.Empty;
    
    public string? PostingUrl { get; set; }

    public string? Address { get; set; }

    [DataType(DataType.Date)]
    public DateTime? Deadline { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required")]
    public JobStatus Status { get; set; }
    
    public int? FolderId { get; set; }
    public Folder? Folder { get; set; }
    
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}