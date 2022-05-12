using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Job : OwnedModel
{
    public string Title { get; set; } = string.Empty;
    public string? PostingUrl { get; set; }
    public string? Description { get; set; }
    public string? ApplicationUrl { get; set; }
    public string? AdditionalNotes { get; set; }
    public DateTime Deadline { get; set; }
    public JobStatus Status { get; set; }
    public Address? Address { get; set; }
    public List<Tag>? Tags { get; set; }
    public Guid JobBoardId { get; set; }
    public JobBoard JobBoard { get; set; }
}