using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

[Table("folders")]
public class Folder : OwnedModel
{
    [Required(ErrorMessage = "The field {0} is required")]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(500)]
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required")]
    [RegularExpression("^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$")]
    public string? Color { get; set; }
    public ICollection<Job>? Jobs { get; set; }
}