using Celestia.Api.Interfaces;
using Celestia.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[Route("/api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public string Get()
    {
        return "API Test";
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AccountDto>> Get(int id)
    {
        var account = await _accountService.GetAsync(id);
        if (account == null) return NotFound();
        return Ok(account);
    }
}