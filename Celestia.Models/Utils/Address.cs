namespace Celestia.Models.Utils;

public class Address
{
    public Guid Id { get; set; }
    public string? Street { get; set; }
    public string? StreetNumber { get; set; }
    public string? State { get; set; }
    public string? CountryCode { get; set; }
    public string? CountryName { get; set; }
    public string? PostalCode { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
}