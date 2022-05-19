using AutoMapper;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly GenericService<Contact, IRepository<Contact>> _contactService;
    private readonly IMapper _mapper;

    public ContactController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _contactService = new GenericService<Contact, IRepository<Contact>>(unitOfWork.ContactRepository, unitOfWork);
    }
    
    // GET: api/Contact
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ContactResultDto>>> GetAll()
    {
        var contacts = await _contactService.GetAllAsync();
        var contactResultDtos = _mapper.Map<IEnumerable<ContactResultDto>>(contacts);
        return Ok(contactResultDtos);
    }

    // GET: api/Contact/5
    [HttpGet("{id}", Name = "GetContactById")]
    public async Task<ActionResult<ContactResultDto>> Get(int id)
    {
        var contact = await _contactService.GetAsync(id);
        
        if (contact == null) return NotFound();

        var contactResultDto = _mapper.Map<ContactResultDto>(contact);
        return Ok(contactResultDto);
    }

    // POST: api/Contact
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post([FromBody] ContactAddDto? value)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (value is null) return BadRequest("Contact is empty");
        
        var contact = _mapper.Map<Contact>(value);
        var contactResult = await _contactService.AddAsync(contact);
        var contactResultDto =  _mapper.Map<ContactResultDto>(contactResult);
        return CreatedAtRoute("GetContactById", new { id = contactResult.Id }, contactResultDto);
    }

    // PUT: api/Contact/5
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] ContactEditDto value)
    {
        if (id != value.Id) return BadRequest();
        var contact = await _contactService.GetAsync(id);
        
        if (contact is null) return NotFound();

        if (!ModelState.IsValid) return BadRequest();
        
        
        var mappedContact = _mapper.Map(value, contact);
        
        var isEdited = await _contactService.UpdateAsync(id, mappedContact);
        
        if (!isEdited) return BadRequest();
        
        return NoContent();
    }
    
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(int id)
    {
        var isDeleted = await _contactService.Delete(id);
        return isDeleted ? NoContent() : NotFound();
    }
}