using Celestia.Models.Utilities;

namespace Celestia.Models.Dto;

public class JobDto
{
    public JobDto() {}
    
    public JobDto(Job job)
    {
        Id = job.Id;
        Title = job.Title;
        Description = job.Description;
        PostingUrl = job.PostingUrl;
        Address = job.Address;
        Deadline = job.Deadline.HasValue ? DateUtilities.ToUnixSeconds((DateTime)job.Deadline) : 0;
        Status = job.Status.ToString();
    }

    public int Id { get; set; } = 0;

    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public string? PostingUrl { get; set; }
    
    public string? Address { get; set; }

    public int Deadline { get; set; } = DateUtilities.ToUnixSeconds(DateTime.Now);
    
    public string Status { get; set; }
}