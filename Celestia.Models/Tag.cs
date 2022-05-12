using Celestia.Models.Abstractions;

namespace Celestia.Models;

public class Tag : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}