namespace ApiWeatherForecast.Services;

public interface IWeatherForecastApplicationService
{
    public void AddForecast(int temperature, DateTime dateForecast);
    public void GetWeekWeatherForecast();
}