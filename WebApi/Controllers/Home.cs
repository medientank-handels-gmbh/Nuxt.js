using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Home : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "Hello World!";
    }
}