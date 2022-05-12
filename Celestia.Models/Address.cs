using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Address : BaseModel
{
    public string Street { get; set; } = string.Empty;
    public string StreetNumber { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Zip { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}