using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dtos.Contact;

public class ContactEditDto
{
    public int Id { get; set; }
    
    [StringLength(80, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
    public string? Name { get; set; }
    
    [MaxLength(30,  ErrorMessage = "The field can't be longer than 30")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    
    [MaxLength(255, ErrorMessage = "The field can't be longer than 255")]
    [EmailAddress(ErrorMessage ="Invalid email address")]
    public string? Email { get; set; }
    
    public int? CompanyId { get; set; }
}