using Celestia.Models;
using Celestia.Models.Dto;

namespace Celestia.Api.Interfaces;

public interface ICompanyService
{
    Task<IEnumerable<CompanyDto>> GetAllAsync();
    Task<CompanyDto?> GetAsync(int id);
    Task<Company> AddAsync(CompanyDto companyDto);
    void Remove();
    Task UpdateAsync(int id, CompanyDto companyDto);
}