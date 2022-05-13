using Celestia.Api.Interfaces;
using Celestia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        this._accountService = accountService;
    }
    [HttpGet]
    public string Get()
    {
        return "API Test";
    }
    
    [HttpGet("{Id}")]
    public async Task<IActionResult> Get(int Id)
    {
        var account = await _accountService.GetAsync(Id);
        if (account == null) return NotFound();
        return Ok(account);
    }
}