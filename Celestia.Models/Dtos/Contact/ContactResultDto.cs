namespace Celestia.Models.Dtos.Contact;

public class ContactResultDto
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Phone { get; set; }
    
    public string? Email { get; set; }
    
    public int? CompanyId { get; set; }
}