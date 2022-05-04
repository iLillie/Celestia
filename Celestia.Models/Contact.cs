namespace Celestia.Models;

public class Contact
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Title { get; set; }
    public List<string>? Phones { get; set; }
    public List<string>? Emails { get; set; }
    public List<Social>? Socials { get; set; }
}