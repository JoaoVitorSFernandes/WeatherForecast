using ApiWeatherForecast.Models;

namespace ApiWeatherForecast.Services;

public interface IWeatherForecastRepository
{
   public void CreateNewWeatherForecast (WeatherForecast weatherForecast);
   public void UpdateWeatherForecast(int temperature);
   public void GetTheWeeksWeatherForecast();
}