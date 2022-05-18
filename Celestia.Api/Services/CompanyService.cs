using Celestia.Api.Interfaces;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Api.Services;

public class CompanyService : ICompanyService
{
    private readonly ApplicationDbContext _dbContext;

    public CompanyService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CompanyDto>> GetAllAsync()
    {
        return await _dbContext.Companies.Select(c => new CompanyDto(c)).ToListAsync();;
    }

    public async Task<CompanyDto?> GetAsync(int id)
    {
        var company = await _dbContext.Companies.FindAsync(id);

        if (company is null) return null;
        
        return new CompanyDto(company);
    }

    public async Task<Company> AddAsync(CompanyDto companyDto)
    {
        var company = Company.MapDto(companyDto);
        await _dbContext.Companies.AddAsync(company);
        await _dbContext.SaveChangesAsync();
        return company;
    }
    public void Remove() {}

    public async Task UpdateAsync(int id, CompanyDto companyDto)
    { 
        var company = await _dbContext.Companies.FirstAsync(j => j.Id == id);
        company.Update(companyDto);
        _dbContext.Companies.Update(company);
        await _dbContext.SaveChangesAsync();
    }
}