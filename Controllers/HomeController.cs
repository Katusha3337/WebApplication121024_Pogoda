using Microsoft.AspNetCore.Mvc;
using WebApplication121024_Pogoda.Models;
using WebApplication121024_Pogoda.Servises;

namespace WebApplication121024_Pogoda.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CitySelectionModel());
        }

        [HttpPost]
        public IActionResult Index(CitySelectionModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Weather", new { city = model.City });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Weather(string city)
        {
            var weather = _weatherService.GetWeather(city);
            return View(weather);
        }
    }
}