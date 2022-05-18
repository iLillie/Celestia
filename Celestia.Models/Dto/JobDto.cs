using Celestia.Models.Utilities;

namespace Celestia.Models.Dto;

public class JobDto
{
    public JobDto() {}
    public JobDto(Job job)
    {
        Id = job.Id;
        AuthorId = job.AuthorId;
        Title = job.Title;
        Description = job.Description;
        PostingUrl = job.PostingUrl;
        Address = job.Address;
        Deadline = job.Deadline.HasValue ? DateUtilities.ToUnixSeconds((DateTime)job.Deadline) : 0;
        Status = job.Status.ToString();
    }
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    public string? PostingUrl { get; set; }
    
    public string? Address { get; set; }
    
    public int Deadline { get; set; }
    
    public string Status { get; set; }
}