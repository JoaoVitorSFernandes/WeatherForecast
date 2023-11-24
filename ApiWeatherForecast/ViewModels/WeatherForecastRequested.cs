using System.ComponentModel.DataAnnotations;

namespace ApiWeatherForecast.ViewModels;

public class WeatherForecastRequested
{
    [Required(ErrorMessage = "Is required")]
    [Range(-60, 60, ErrorMessage = "Temperature cannot be more than 60C and cannot be less than 60C degress.")]
    public int Temperature { get; set; }

    [Required(ErrorMessage = "Is Required")]
    public DateTime DateForecast { get; set; }
}