using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dtos.Folder;

public class FolderAddDto
{
    [Required(ErrorMessage = "The field {0} is required")]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(500)]
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required")]
    [RegularExpression("^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$")]
    public string? Color { get; set; }
}