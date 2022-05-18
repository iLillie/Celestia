using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("contacts")]
public class Contact : OwnedModel
{
    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(30)]
    public string? Phone { get; set; } = string.Empty;
    
    [MaxLength(255)]
    public string? Email { get; set; } = string.Empty;
    
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}