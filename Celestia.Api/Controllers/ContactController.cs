using AutoMapper;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/contact")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly GenericService<Contact, IRepository<Contact>> _contactService;
    private readonly IMapper _mapper;
    private readonly IAccountService _accountService;

    public ContactController(IMapper mapper, IUnitOfWork unitOfWork, IAccountService accountService)
    {
        _mapper = mapper;
        _contactService = new GenericService<Contact, IRepository<Contact>>(unitOfWork.ContactRepository, unitOfWork);
        _accountService = accountService;
    }
    
    // GET: api/Contact
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ContactResultDto>>> GetAll()
    {
        var contactList = await _contactService.GetAllAsync();
        
        if(!contactList.Any())
            return NotFound("No contacts found");

        return Ok(_mapper.Map<IEnumerable<ContactResultDto>>(contactList));
    }

    // GET: api/contact/5
    [HttpGet("{id:int}", Name = "GetContactById")]
    public async Task<ActionResult<ContactResultDto>> Get(int id)
    {
        var contact = await _contactService.GetAsync(id, User.Identity.Name);
        var contactNotFound = contact is null;
        
        if(contactNotFound)
            return NotFound($"Contact with id: {id} not found");
        
        return Ok(_mapper.Map<ContactResultDto>(contact));
    }

    // POST: api/contact
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ContactAddDto? newContact)
    {
        var invalidContact = !ModelState.IsValid || newContact is null;
        
        if (invalidContact) 
            return BadRequest("Invalid model provided for a new contact to be created");
        
        var account = await _accountService.GetUserFromAuth0Id(User.Identity.Name);
        var mappedContact = _mapper.Map<Contact>(newContact);
        mappedContact.AuthorId = account.Id;
        
        var contact = await _contactService.AddAsync(mappedContact);
        return CreatedAtRoute(
            "GetContactById", 
            new { id = contact.Id }, 
            _mapper.Map<ContactResultDto>(contact)
            );
    }

    // PUT: api/contact/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, [FromBody] ContactEditDto companyEditDto)
    {
        
        var invalidContact = !ModelState.IsValid && id != companyEditDto.Id;
        
        if (invalidContact) 
            return BadRequest("Invalid model provided for a contact to be edited");
        
        var contact = await _contactService.GetAsync(id, User.Identity.Name);
        var contactNotFound = contact is null;
        
        if(contactNotFound)
            return NotFound($"Contact with id: {id} not found");

        await _contactService.UpdateAsync(id, _mapper.Map(companyEditDto, contact)!);
        return NoContent();
    }
    
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var contact = await _contactService.GetAsync(id, User.Identity.Name);
        var contactNotFound = contact is null;
        
        if(contactNotFound)
            return NotFound($"Contact with id: {id} not found");
        
        await _contactService.Delete(contact!);
        return NoContent();
    }
}