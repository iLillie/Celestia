namespace Celestia.Models.Abstractions;

public class OwnedModel : BaseModel
{
    public int AuthorId { get; set; }
    public Account Author { get; set; }
}