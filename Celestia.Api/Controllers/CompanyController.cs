using Celestia.Api.Interfaces;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    
    // GET: api/Company
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyDto>>> Get()
    {
        return Ok(await _companyService.GetAllAsync());
    }

    // GET: api/Company/5
    [HttpGet("{id}", Name = "GetCompanyById")]
    public async Task<ActionResult<CompanyDto>> Get(int id)
    {
        return await _companyService.GetAsync(id) ?? throw new InvalidOperationException();
    }

    // POST: api/Company
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CompanyDto? value)
    {
        if (value is null) return BadRequest("Job is empty");

        var company = await _companyService.AddAsync(value);
        return CreatedAtRoute("GetCompanyById", new { id = company.Id }, new CompanyDto(company));
    }

    // PUT: api/Company/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] CompanyDto value)
    {
        await _companyService.UpdateAsync(id, value);
        return NoContent();
    }
}