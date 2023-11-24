namespace ApiWeatherForecast.Models.Exception;

public sealed class WeatherForecastException : ApplicationException
{
    public WeatherForecastException(string message) : base(message) { }
}