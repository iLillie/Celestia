using System.ComponentModel.DataAnnotations;
using Celestia.Models.Dtos.Job;

namespace Celestia.Models.Dtos.Folder;

public class FolderResultDto
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? Color { get; set; }
    
    public ICollection<JobResultDto>? Jobs { get; set; }

}