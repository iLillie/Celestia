using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dtos.Company;

public class CompanyEditDto
{
    [Required(ErrorMessage = "The field {0} is required")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(80, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    
    public string? HomepageUrl { get; set; }
    
    public string? LogoUrl { get; set; }
    
    public string? Address { get; set; }
}