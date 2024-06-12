using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Mundri_task.Models;


namespace Mundri_task.Services
{
    public class WeatherServices
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["OpenWeatherMap:ApiKey"];
        }

        public async Task<WeatherInfo> GetWeatherAsync(string city)
        {
            var response = await _httpClient.GetFromJsonAsync<WeatherInfo>($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");
            return response;
        }

    }
}
