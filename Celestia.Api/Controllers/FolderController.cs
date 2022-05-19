using AutoMapper;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Folder;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FolderController : ControllerBase
{
    private readonly GenericService<Folder, IRepository<Folder>> _folderService;
    private readonly IMapper _mapper;

    public FolderController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _folderService = new GenericService<Folder, IRepository<Folder>>(unitOfWork.FolderRepository, unitOfWork);
    }
    
    // GET: api/Folder
    [HttpGet]
    public async Task<ActionResult<IEnumerable<FolderResultDto>>> GetAll()
    {
        var folders = await _folderService.GetAllAsync();
        var folderResultDtos = _mapper.Map<IEnumerable<FolderResultDto>>(folders);
        return Ok(folderResultDtos);
    }

    // GET: api/Folder/5
    [HttpGet("{id}", Name = "GetFolderById")]
    public async Task<ActionResult<FolderResultDto>> Get(int id)
    {
        var folder = await _folderService.GetAsync(id);
        
        if (folder == null) return NotFound();

        var folderResultDto = _mapper.Map<FolderResultDto>(folder);
        return Ok(folderResultDto);
    }

    // POST: api/Folder
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post([FromBody] FolderAddDto? value)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (value is null) return BadRequest("Folder is empty");
        
        var folder = _mapper.Map<Folder>(value);
        var folderResult = await _folderService.AddAsync(folder);
        var folderResultDto =  _mapper.Map<FolderResultDto>(folderResult);
        return CreatedAtRoute("GetFolderById", new { id = folderResult.Id }, folderResultDto);
    }

    // PUT: api/Folder/5
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(int id, [FromBody] FolderEditDto value)
    {
        if (id != value.Id) return BadRequest();
        var folder = await _folderService.GetAsync(id);
        
        if (folder is null) return NotFound();

        if (!ModelState.IsValid) return BadRequest();
        
        
        var mappedFolder = _mapper.Map(value, folder);
        
        var isEdited = await _folderService.UpdateAsync(id, mappedFolder);
        
        if (!isEdited) return BadRequest();
        
        return NoContent();
    }
    
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(int id)
    {
        var isDeleted = await _folderService.Delete(id);
        return isDeleted ? NoContent() : NotFound();
    }
}