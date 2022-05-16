using System.ComponentModel.DataAnnotations;

namespace Celestia.Models.Dto;

public class JobBoardUpdateDto
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(80, ErrorMessage = "Name can't be longer than 80 characters")]
    public string Name { get; set; }
}