using Microsoft.AspNetCore.Mvc;

namespace tr_backend_itsense.Controllers;

[ApiController]
[Route("[controller]")]
public class Aaoeu : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<Aaoeu> _logger;

    public Aaoeu(ILogger<Aaoeu> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return "aoeu";
    }
}
