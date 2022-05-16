using Celestia.Models.Utilities;

namespace Celestia.Models.DTO;

public class ContactDto
{
    public ContactDto(Contact contact)
    {
        Id = contact.Id;
        Name = contact.Name;
        LastName = contact.LastName ?? string.Empty;
        Phone = contact.Phone ?? string.Empty;
        Email = contact.Email ?? string.Empty;
        Notes = contact.AdditionalNotes ?? string.Empty;
        CompanyId = contact.CompanyId;
        CreatedAt = DateUtilities.ToUnixSeconds(contact.CreatedAt);
        UpdatedAt = DateUtilities.ToUnixSeconds(contact.UpdatedAt);
    }

    public int Id { get; }
    public string Name { get; }
    public string LastName { get; }
    public string Phone { get; }
    public string Email { get; }
    public string Notes { get; }
    public int? CompanyId { get; }
    public int CreatedAt { get; }
    public int UpdatedAt { get; }
}