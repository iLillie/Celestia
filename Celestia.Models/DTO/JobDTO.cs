namespace Celestia.Models.DTO;

public class JobDTO
{
    private readonly int _id;
    private readonly string _title;
    private readonly string _postingUrl;
    private readonly string _description;
    private readonly string _additionalNotes;
    private readonly string _applicationUrl;
    private readonly string _deadline;
    private readonly string _status;

    public JobDTO(Job job)
    {
        _title = job.Title;
        _id = job.Id;
        _postingUrl = string.IsNullOrEmpty(job.PostingUrl) ? "" : job.PostingUrl;
        _description = string.IsNullOrEmpty(job.Description) ? "" : job.Description;
        _additionalNotes = string.IsNullOrEmpty(job.AdditionalNotes) ? "" : job.AdditionalNotes;
        _applicationUrl = string.IsNullOrEmpty(job.AdditionalNotes) ? "" : job.AdditionalNotes;
        _deadline = job.Deadline.ToShortDateString();
        _status = job.Status.ToString();
    }

    public int Id => _id;
    public string Title => _title;
    public string PostingUrl => _postingUrl;
    public string Description => _description;
    public string ApplicationUrl => _applicationUrl;
    public string Note => _additionalNotes;
    public string Deadline => _deadline;
    public string Status => _status;
}
