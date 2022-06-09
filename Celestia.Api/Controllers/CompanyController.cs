using AutoMapper;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Company;
using Celestia.Models.Dtos.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/company")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly GenericService<Company, IRepository<Company>> _companyService;
    private readonly IMapper _mapper;

    public CompanyController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _companyService = new GenericService<Company, IRepository<Company>>(unitOfWork.CompanyRepository, unitOfWork);
    }

    // GET: api/company
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyResultDto>>> GetAll()
    {
        var companyList = await _companyService.GetAllAsync();

        if (!companyList.Any())
            return NotFound("No companies found");

        return Ok(_mapper.Map<IEnumerable<CompanyResultDto>>(companyList));
    }

    // GET: api/company/5
    [HttpGet("{id}", Name = "GetCompanyById")]
    public async Task<ActionResult<CompanyResultDto>> Get(int id)
    {
        var company = await _companyService.GetAsync(id, User.Identity.Name);
        var companyNotFound = company is null;
        
        if (companyNotFound)
            return NotFound($"Company with id: {id} not found");

        return Ok(_mapper.Map<CompanyResultDto>(company));
    }

    // POST: api/company
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CompanyAddDto? newCompany)
    {
        var invalidCompany = !ModelState.IsValid || newCompany is null;
        
        if (invalidCompany) 
            return BadRequest("Invalid model provided for a new company to be created");

        var company = await _companyService.AddAsync(_mapper.Map<Company>(newCompany));
        
        return CreatedAtRoute(
            "GetCompanyById", 
            new { id = company.Id }, 
            _mapper.Map<CompanyResultDto>(company)
            );
    }

    // PUT: api/company/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, [FromBody] CompanyEditDto companyEditDto)
    {
        var invalidCompany = !ModelState.IsValid && id != companyEditDto.Id;
        
        if (invalidCompany) 
            return BadRequest("Invalid model provided for a company to be edited");
        
        var company = await _companyService.GetAsync(id, User.Identity.Name);
        var companyNotFound = company is null;
        
        if (companyNotFound)
            return NotFound($"Company with id: {id} not found");
        
        await _companyService.UpdateAsync(id, _mapper.Map(companyEditDto, company)!);
        return NoContent();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var company = await _companyService.GetAsync(id, User.Identity.Name);
        
        var companyNotFound = company is null;
        
        if (companyNotFound)
            return NotFound($"Company with id: {id} not found");
        
        await _companyService.Delete(company!);
        return NoContent();
    }
}