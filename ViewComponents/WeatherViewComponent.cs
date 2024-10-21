using Microsoft.AspNetCore.Mvc;
using WebApplication121024_Pogoda.Servises;

namespace WebApplication121024_Pogoda.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IWeatherService _weatherService;

        public WeatherViewComponent(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IViewComponentResult Invoke(string city)
        {
            var weather = _weatherService.GetWeather(city);
            return View(weather);
        }
    }
}