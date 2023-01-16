using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.WebApi.HealthCheck;

[ApiController]
public class HealthCheckController : ControllerBase
{
    public IActionResult Get()
    {
        return Ok("");
    }
}
