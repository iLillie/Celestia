using Microsoft.AspNetCore.Mvc;

namespace Celestia.Api.Controllers;

[ApiController]
[Route("api/home")]
public class Home : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "Hello World";
    }
}