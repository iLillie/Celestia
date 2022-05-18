using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("companies")]
public class Company : OwnedModel
{
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(80, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    
    public string? WebsiteUrl { get; set; }
    
    public string? IconUrl { get; set; }
    
    public string? Address { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    
    public ICollection<Job>? Job { get; set; }
}