using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfigsController : ControllerBase
{
    private readonly ILogger<ConfigsController> _logger;

    public ConfigsController(ILogger<ConfigsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        string config1 = "Hola Latino .NET Online";
        _logger.LogInformation(config1);

        var response = new
        {
            config1 = config1
        };
        return Ok(response);
    }
}
