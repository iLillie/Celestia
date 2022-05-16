using Celestia.Models.Abstractions;
using Celestia.Models.Dto;

namespace Celestia.Models;

public class JobBoard : OwnedModel
{
    public JobBoard() {}
    public JobBoard(JobBoardCreationDto creationDto)
    {
        Name = creationDto.Name!;
        AuthorId = creationDto.AuthorId;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Update(JobBoardUpdateDto updateDto)
    {
        Name = updateDto.Name;
        UpdatedAt = DateTime.UtcNow;
    }
    
    public string Name { get; set; } = string.Empty;
    public List<Job> Jobs { get; set; } = new();
}