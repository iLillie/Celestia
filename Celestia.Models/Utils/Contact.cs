using Celestia.Models.Abstractions;

namespace Celestia.Models.Utils;

public class Contact : BaseModel
{
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? AdditionalInfo { get; set; }
}