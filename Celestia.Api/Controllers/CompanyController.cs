using AutoMapper;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Company;
using Celestia.Models.Dtos.Job;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
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
    
    // GET: api/Company
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyResultDto>>> GetAll()
    {
        var companies = await _companyService.GetAllAsync();
        var companyResultDtos = _mapper.Map<IEnumerable<CompanyResultDto>>(companies);
        return Ok(companyResultDtos);
    }

    // GET: api/Company/5
    [HttpGet("{id}", Name = "GetCompanyById")]
    public async Task<ActionResult<CompanyResultDto>> Get(int id)
    {
        var company = await _companyService.GetAsync(id);
        
        if (company == null) return NotFound();

        var companyResultDto = _mapper.Map<CompanyResultDto>(company);
        return Ok(companyResultDto);
    }

    // POST: api/Company
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post([FromBody] CompanyAddDto? value)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (value is null) return BadRequest("Company is empty");
        
        var company = _mapper.Map<Company>(value);
        var companyResult = await _companyService.AddAsync(company);
        var companyResultDto =  _mapper.Map<CompanyResultDto>(companyResult);
        return CreatedAtRoute("GetCompanyById", new { id = companyResult.Id }, companyResultDto);
    }

    // PUT: api/Company/5
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] CompanyEditDto value)
    {
        if (id != value.Id) return BadRequest();
        var company = await _companyService.GetAsync(id);
        
        if (company is null) return NotFound();

        if (!ModelState.IsValid) return BadRequest();
        
        
        var mappedCompany = _mapper.Map(value, company);
        
        var isEdited = await _companyService.UpdateAsync(id, mappedCompany);
        
        if (!isEdited) return BadRequest();
        
        return NoContent();
    }
    
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(int id)
    {
        var isDeleted = await _companyService.Delete(id);
        return isDeleted ? NoContent() : NotFound();
    }
}