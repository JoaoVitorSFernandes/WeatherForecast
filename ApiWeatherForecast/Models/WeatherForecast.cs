using ApiWeatherForecast.Models.Exception;

namespace ApiWeatherForecast.Models;

public class WeatherForecast
{
    public int Temperature { get; set; }
    public DateTime DateForecast { get; set; }
    public string DescriptionForecast { get; set; }

    private readonly Dictionary<int, string> GetDescriptionForecast = new Dictionary<int, string>()
    {
        {-10, "Freezing"}, {-3, "Bracing"}, {3, "Chilly"}, {11, "Cool"}, {18, "Mild"}, {20, "Warm"},
        {26, "Balmy"}, {30, "Hot"}, {35, "Sweltering"}, {40, "Scorch"},
    };

    public WeatherForecast(int temperature, DateTime dateForecast)
    {
        SetTemperature(temperature);
        SetDateForecast(dateForecast);
    }

    private void SetTemperature(int temperature)
    {
        if (!(temperature >= -60 && temperature <= 60))
            throw new WeatherForecastException("Temperature cannot be more than 60C and cannot be less than 60C degress.");

        Temperature = temperature;
        SetDescriptionForecast();
    }

    private void SetDateForecast(DateTime dateForecast)
    {
        var dateCurrent = DateTime.Now;
        if (dateForecast.CompareTo(dateCurrent) > 0)
            throw new WeatherForecastException("Input forecats cannot be in the past");

        DateForecast = dateForecast;
    }

    private void SetDescriptionForecast()
    {
        if (!GetDescriptionForecast.ContainsKey(Temperature))
            throw new WeatherForecastException("There is no forecast description for the reported temperature");

        DescriptionForecast = GetDescriptionForecast[Temperature];
    }
}