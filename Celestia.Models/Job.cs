using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;
using Celestia.Models.Dto;

namespace Celestia.Models;

[Table("jobs")]
public class Job : OwnedModel
{
    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    public string Description { get; set; } = string.Empty;
    
    public string? PostingUrl { get; set; }

    public string? Address { get; set; }

    [DataType(DataType.Date)]
    public DateTime? Deadline { get; set; }
    
    public JobStatus Status { get; set; }
    
    public int? FolderId { get; set; }
    public Folder? Folder { get; set; }
    
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

    public static Job MapDto(JobDto jobDto)
    {
        return new Job()
        {
            Id = 0,
            Title = jobDto.Title,
            Description = jobDto.Description,
            PostingUrl = jobDto.PostingUrl,
            Address = jobDto.Address,
            Deadline =  DateTimeOffset.FromUnixTimeSeconds(jobDto.Deadline).DateTime.ToUniversalTime(),
            Status = (JobStatus)Enum.Parse(typeof(JobStatus), jobDto.Status),
            CreatedAt = DateTime.UtcNow,
            AuthorId = jobDto.AuthorId
        };
    }

    public void Update(JobDto jobDto)
    {
        Title = jobDto.Title;
        Description = jobDto.Description;
        PostingUrl = jobDto.PostingUrl;
        Address = jobDto.Address;
        Deadline = DateTimeOffset.FromUnixTimeSeconds(jobDto.Deadline).DateTime.ToUniversalTime();
        Status = (JobStatus)Enum.Parse(typeof(JobStatus), jobDto.Status);
    }
}