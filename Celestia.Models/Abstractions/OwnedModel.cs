namespace Celestia.Models.Abstractions;

public class OwnedModel : BaseModel
{
    public Guid? AuthorId { get; set; }
    public Account Author { get; set; }
}