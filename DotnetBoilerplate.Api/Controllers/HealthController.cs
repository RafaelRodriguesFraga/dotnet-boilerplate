using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "OK";
    }
}