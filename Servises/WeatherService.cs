using WebApplication121024_Pogoda.Models;

namespace WebApplication121024_Pogoda.Servises
{
    public interface IWeatherService
    {
        WeatherInfo GetWeather(string city);
    }

    public class WeatherService : IWeatherService
    {
        private readonly Dictionary<string, WeatherInfo> _weatherData = new()
    {
        { "Одесса", new WeatherInfo { City = "Одесса", Temperature = "25°C", Description = "Sunny" } },
        { "Черноморск", new WeatherInfo { City = "Черноморск", Temperature = "23°C", Description = "Partly Cloudy" } },
        { "Николаев", new WeatherInfo { City = "Николаев", Temperature = "22°C", Description = "Clear Sky" } },
        { "Киев", new WeatherInfo { City = "Киев", Temperature = "18°C", Description = "Rainy" } },
        { "Днепр", new WeatherInfo { City = "Днепр", Temperature = "20°C", Description = "Overcast" } }
    };

        public WeatherInfo GetWeather(string city)
        {
            return _weatherData.ContainsKey(city) ? _weatherData[city] : new WeatherInfo { City = city, Temperature = "N/A", Description = "N/A" };
        }
    }
}
