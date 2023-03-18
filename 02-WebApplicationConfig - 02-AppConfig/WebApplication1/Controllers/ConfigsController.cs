using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfigsController : ControllerBase
{
    private readonly ILogger<ConfigsController> _logger;
    private readonly IConfiguration _configuration;
    private readonly IWebHostEnvironment _env;

    public ConfigsController(ILogger<ConfigsController> logger,
        IConfiguration configuration,
        IWebHostEnvironment env)
    {
        _logger = logger;
        _configuration = configuration;
        _env = env;
    }

    [HttpGet]
    public IActionResult Get()
    {
        //Get configuration
        string config1 = _configuration["Config1"]!;
        string config2 = _configuration.GetValue<string>("Config2")!;
        string config3 = _configuration.GetValue<string>("Config3")!;
        string webappconfig1 = _configuration.GetValue<string>("WebApplication1:Settings:Config1")!;
        int webappconfig2 = _configuration.GetValue<int>("WebApplication1:Settings:Config2")!;
        bool webappconfig3 = _configuration.GetValue<bool>("WebApplication1:Settings:Config3")!;

        //Log configuration
        _logger.LogInformation($"Config1 = {config1}");
        _logger.LogInformation($"Config2 = {config2}");
        _logger.LogInformation($"Config3 = {config3}");
        _logger.LogInformation($"Settings:WebAppConfig1 = {webappconfig1}");
        _logger.LogInformation($"Settings:WebAppConfig2 = {webappconfig2}");
        _logger.LogInformation($"Settings:WebAppConfig3 = {webappconfig3}");

        //Create and send response
        var response = new
        {
            Environment = _env.EnvironmentName,
            config1 = config1,
            config2,
            config3,
            AppSettings = new
            {
                webappconfig1,
                webappconfig2,
                webappconfig3,
            },
        };
        return Ok(response);
    }
}
