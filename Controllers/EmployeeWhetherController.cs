using Microsoft.AspNetCore.Mvc;
using Mundri_task.Services;
using System.Net;

namespace Mundri_task.Controllers
{
    public class EmployeeWhetherController : Controller
    {
        private readonly WeatherServices _weatherService;
        public EmployeeWhetherController(WeatherServices weatherService)
        {
            _weatherService = weatherService;   
            
        }
        public async Task<IActionResult> WeatherEmp(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                city = "DefaultCity"; // Replace with a default city or handle accordingly
            }

            var weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }


    }
}
