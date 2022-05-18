using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("accounts")]
public class Account : BaseModel
{
    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public string? Address { get; set; }
    
    public ICollection<Job>? Jobs { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    
    public ICollection<Company>? Companies { get; set; }
    
    public ICollection<Folder>? Folders { get; set; }
}