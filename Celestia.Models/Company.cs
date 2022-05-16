using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Company : OwnedModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? HomepageUrl { get; set; }
    public string? LogoUrl { get; set; }

    public List<Address>? Locations { get; set; }
    public List<Contact>? Contacts { get; set; }
}