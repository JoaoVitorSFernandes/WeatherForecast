using Microsoft.AspNetCore.Mvc;

namespace ApiWeatherForecast.Controllers;

[ApiController]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("v1/weatherforecast/weatherweek")]
    public async Task<IActionResult> GetAsync()
    {
        return Ok();
    }

    [HttpPost("v1/weatherforecast/")]
    public async Task<IActionResult> PostAsync()
    {
        
        return Ok();
    }
}