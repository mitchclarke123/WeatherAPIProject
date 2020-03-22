using Newtonsoft.Json;
using WeatherAPIProject.WeatherAPI.DataHandling;

namespace WeatherAPIProject.CurrentWeatherSerice.DataHandling
{
    public class CurrentWeatherDTO
    {
        // The class is the model of data.
        public WeatherServiceRoot CurrentWeather { get; set; }

        // Method that creates the above object following passing in the response from the API
        public void DeserializeCurrentWeather(string CurrentWeatherResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<WeatherServiceRoot>(CurrentWeatherResponse);
        }
    }
}
