using Microsoft.AspNetCore.Mvc;

namespace ApiWeatherForecast.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync() => Ok();
}