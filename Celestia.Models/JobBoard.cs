using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class JobBoard : OwnedModel
{
    public string Name { get; set; } = string.Empty;
    public List<Job> Jobs { get; set; } = new();
}