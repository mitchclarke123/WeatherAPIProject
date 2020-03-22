using Newtonsoft.Json;
using WeatherAPIProject.WeatherAPI.DataHandling;

namespace WeatherAPIProject.CurrentWeatherSerice.DataHnadling
{
    public class CurrentWeatherDTO
    {
        // The class is the model of data.
        public WeatherServiceRoot CurrentWeather { get; set; }

        // Method that creates the above object following passing in the response from the API
        public void DeserializeCurrentWeather(string LatestRatesResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<WeatherServiceRoot>(LatestRatesResponse);
        }
    }
}
