using Celestia.Models.Abstractions;
using Celestia.Models.Dto;

namespace Celestia.Models;

public class Job : OwnedModel
{
    public Job() {}
    public Job(JobCreationDto creationDto)
    {
        Title = creationDto.Title;
        PostingUrl = creationDto.PostingUrl ?? string.Empty;
        Description = creationDto.Description ?? string.Empty;
        ApplicationUrl = creationDto.ApplicationUrl ?? string.Empty;
        AdditionalNotes = creationDto.Notes ?? string.Empty;
        Deadline = creationDto.Deadline;
        Status = creationDto.Status;
        JobBoardId = creationDto.JobBoardId;
        AuthorId = creationDto.AuthorId;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Update(JobUpdateDto updateDto)
    {
        Title = updateDto.Title;
        PostingUrl = updateDto.PostingUrl;
        Description = updateDto.Description;
        ApplicationUrl = updateDto.ApplicationUrl;
        AdditionalNotes = updateDto.Notes;
        Deadline = updateDto.Deadline;
        Status = updateDto.Status;
        JobBoardId = updateDto.JobBoardId;
        UpdatedAt = DateTime.UtcNow;
    }
    public string Title { get; set; } = string.Empty;
    public string? PostingUrl { get; set; }
    public string? Description { get; set; }
    public string? ApplicationUrl { get; set; }
    public string? AdditionalNotes { get; set; }
    public DateTime Deadline { get; set; }
    public JobStatus Status { get; set; }
    public Address? Address { get; set; }
    public List<Tag>? Tags { get; set; }
    public int? JobBoardId { get; set; }
    public JobBoard? JobBoard { get; set; }
}