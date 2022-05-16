using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.DTO;

public class JobBoardCreationDto
{
    // TODO: Remove when going to prod
    [Required(ErrorMessage = "Author Id is required")]
    public int? AuthorId;

    [Required(ErrorMessage = "Name is required")]
    [StringLength(80, ErrorMessage = "Name can't be longer than 80 characters")]
    public string? Name;
}