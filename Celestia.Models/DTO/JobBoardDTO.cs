namespace Celestia.Models.DTO;

public class JobBoardDTO
{
    private readonly int _id;
    private readonly string _name;
    private readonly List<JobDTO> _jobList;

    public JobBoardDTO(JobBoard jobBoard)
    {
        _name = jobBoard.Name;
        _id = jobBoard.Id;
        _jobList = jobBoard.Jobs.Select(j => new JobDTO(j)).ToList();
    }

    public int Id => _id;
    public string Name => _name;
    public List<JobDTO> Jobs => _jobList;
}
