using System.Text.Json.Serialization;
using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Account : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string? LastName { get; set; }
    public string? Alias { get; set; } = string.Empty;
    public bool AliasPreferred { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }

    public Address? Address { get; set; }
    
    public List<JobBoard>? JobBoards { get; set; }
    
    public List<Job>? Jobs { get; set; }
    
    public List<Contact>? Contacts { get; set; }
    
    public List<Company>? Companies { get; set; }
}