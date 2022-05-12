using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Contact : OwnedModel
{
    public string Name { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? Phone { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? AdditionalNotes { get; set; } = string.Empty;
    
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
}