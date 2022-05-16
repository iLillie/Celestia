namespace Celestia.Models.Dto;

public class JobBoardDto
{
    public JobBoardDto(JobBoard jobBoard)
    {
        Id = jobBoard.Id;
        Name = jobBoard.Name;
        Jobs = jobBoard.Jobs.Select(job => new JobDto(job)).ToList();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<JobDto> Jobs { get; set; }
}