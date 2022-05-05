namespace Celestia.Models.Utils;

public class Image
{
    public Guid Id { get; set; }
    public ImageType ImageType { get; set; }
    public string? Alt { get; set; }
    public string? Url { get; set; }
    public string? ReferenceId { get; set; }
}