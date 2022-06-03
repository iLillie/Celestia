using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("accounts")]
public class Account : BaseModel
{
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(80, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(255, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
    [EmailAddress(ErrorMessage ="Invalid email address")]
    public string Email { get; set; } = string.Empty;
    
    public string Auth0Id { get; set; } = string.Empty;
    
    public string? Address { get; set; }
    
    public ICollection<Job>? Jobs { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    
    public ICollection<Company>? Companies { get; set; }
    
    public ICollection<Folder>? Folders { get; set; }
}