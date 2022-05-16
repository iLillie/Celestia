using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dto;

public class JobUpdateDto
{
    public string Title { get; set; } = string.Empty;
    public string? PostingUrl { get; set; }
    public string? Description { get; set; }
    public string? ApplicationUrl { get; set; }
    public string? Notes { get; set; }
    public DateTime Deadline { get; set; }
    public JobStatus Status { get; set; }
    public int JobBoardId { get; set; }
}