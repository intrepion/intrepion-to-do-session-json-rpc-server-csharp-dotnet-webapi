using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.WebApi.HealthCheck;

[ApiController]
public class HealthCheckController
{
    public string Get()
    {
        return "";
    }
}
