using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("companies")]
public class Company : OwnedModel
{
    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    public string? HomepageUrl { get; set; }
    
    public string? LogoUrl { get; set; }
    
    public string? Address { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    
    public ICollection<Job>? Job { get; set; }
}