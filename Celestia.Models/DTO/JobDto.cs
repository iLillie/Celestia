using Celestia.Models.Utilities;

namespace Celestia.Models.DTO;

public class JobDto
{
    public JobDto(Job job)
    {
        Id = job.Id;
        Title = job.Title;
        PostingUrl = job.PostingUrl ?? string.Empty;
        Description = job.Description ?? string.Empty;
        Note = job.AdditionalNotes ?? string.Empty;
        ApplicationUrl = job.ApplicationUrl ?? string.Empty;
        Deadline = DateUtilities.ToUnixSeconds(job.Deadline);
        Status = job.Status.ToString();
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string PostingUrl { get; set; }
    public string Description { get; set; }
    public string ApplicationUrl { get; set; }
    public string Note { get; set; }
    public int Deadline { get; set; }
    public string Status { get; set; }
}