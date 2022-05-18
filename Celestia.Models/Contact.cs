using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("contacts")]
public class Contact : OwnedModel
{
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(80, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(30)]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; } = string.Empty;
    
    [MaxLength(255, ErrorMessage = "The field can't be longer than 255")]
    [EmailAddress(ErrorMessage ="Invalid email address")]
    public string? Email { get; set; } = string.Empty;
    
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}