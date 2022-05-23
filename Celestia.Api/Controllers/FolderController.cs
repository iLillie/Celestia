using AutoMapper;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Celestia.Models.Dtos.Folder;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("api/folder")]
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
    
    // GET: api/folder
    [HttpGet]
    public async Task<ActionResult<IEnumerable<FolderResultDto>>> GetAll()
    {
        var folderList = await _folderService.GetAllAsync();

        if (!folderList.Any())
            return NotFound("No folders found");
        
        return Ok(_mapper.Map<IEnumerable<FolderResultDto>>(folderList));
    }

    // GET: api/folder/5
    [HttpGet("{id:int}", Name = "GetFolderById")]
    public async Task<ActionResult<FolderResultDto>> Get(int id)
    {
        var folder = await _folderService.GetAsync(id);
        var folderNotFound = folder is null;
        
        if(folderNotFound)
            return NotFound($"Folder with id: {id} not found");
        
        return Ok(_mapper.Map<FolderResultDto>(folder));
    }

    // POST: api/folder
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] FolderAddDto? newFolder)
    {
        var invalidFolder = !ModelState.IsValid || newFolder is null;
        if (invalidFolder) 
            return BadRequest("Invalid model provided for a new folder to be created");
        
        var folder = await _folderService.AddAsync(_mapper.Map<Folder>(newFolder));
        return CreatedAtRoute(
            "GetFolderById", 
            new { id = folder.Id }, 
            _mapper.Map<FolderResultDto>(folder)
            );
    }

    // PUT: api/folder/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, [FromBody] FolderEditDto folderEditDto)
    {
        var invalidFolder = !ModelState.IsValid && id != folderEditDto.Id;
        
        if (invalidFolder) 
            return BadRequest("Invalid model provided for a folder to be edited");
        
        var folder = await _folderService.GetAsync(id);
        var folderNotFound = folder is null;
        
        if (folderNotFound)
            return NotFound($"Folder with id: {id} not found");
        
        await _folderService.UpdateAsync(id, _mapper.Map(folderEditDto, folder)!);
        return NoContent();
    }
    
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var folder = await _folderService.GetAsync(id);
        var folderNotFound = folder is null;
        
        if(folderNotFound)
            return NotFound($"Folder with id: {id} not found");
        
        await _folderService.Delete(folder!);
        return NoContent();
    }
}