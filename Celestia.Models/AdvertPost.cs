using Celestia.Models.Abstractions;
using Celestia.Models.Utils;

namespace Celestia.Models;

public class AdvertPost : BaseModel
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
    public PostStatus Status { get; set; }
    
    public Guid ContactId { get; set; }
    public Contact? Contact { get; set; }
    
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }

    public enum PostStatus
    {
        Active,
        Expired,
        Inactive,
        Archived,
    }
}