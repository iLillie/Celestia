namespace Celestia.Models.Utils;

public class Address
{
    public Guid Id { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? Town { get; set; }
    public string? ZipCode { get; set; }
}