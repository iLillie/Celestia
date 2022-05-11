using Celestia.Models.Abstractions;
using Celestia.Models.Utils;

namespace Celestia.Models;

public class Company : BaseModel
{
    public string? Name { get; set; }
    public string? Homepage { get; set; }
    
    public Image? Logo { get; set; }
    public Guid LogoId { get; set; }
    
    public List<Contact> Contacts { get; set; } = new();
    public List<AdvertPost> AdvertPosts { get; set; } = new();
    public List<AdvertPost> Positions { get; set; } = new();
}