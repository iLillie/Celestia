using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Celestia.Models.Abstractions;
using Celestia.Models.Dto;

namespace Celestia.Models;

[Table("companies")]
public class Company : OwnedModel
{
    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;
    
    public string? HomepageUrl { get; set; }
    
    public string? LogoUrl { get; set; }
    
    public string? Address { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    
    public ICollection<Job>? Job { get; set; }
    
    public static Company MapDto(CompanyDto companyDto)
    {
        return new Company()
        {
            Id = companyDto.Id,
            Name = companyDto.Name,
            HomepageUrl = companyDto.HomepageUrl,
            LogoUrl = companyDto.LogoUrl,
            Address = companyDto.Address,
            AuthorId = 0 // TODO: Update before Auth system
        };
    }

    public void Update(CompanyDto companyDto)
    {
        Name = companyDto.Name;
        HomepageUrl = companyDto.HomepageUrl;
        LogoUrl = companyDto.LogoUrl;
        Address = companyDto.Address;
    }
}