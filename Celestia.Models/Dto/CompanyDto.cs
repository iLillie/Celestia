namespace Celestia.Models.Dto;

public class CompanyDto
{
    public CompanyDto() {}

    public CompanyDto(Company company)
    {
        Id = company.Id;
        Name = company.Name;
        HomepageUrl = company.HomepageUrl;
        LogoUrl = company.LogoUrl;
        Address = company.Address;
    }
    
    public int Id { get; set; } = 0;

    public string Name { get; set; } = string.Empty;
    
    public string? HomepageUrl { get; set; }
    
    public string? LogoUrl { get; set; }
    
    public string? Address { get; set; }
}