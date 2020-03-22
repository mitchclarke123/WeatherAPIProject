using WeatherAPIProject;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPIProject.CurrentWeatherService.HTTPManager;
using WeatherAPIProject.CurrentWeatherSerice.DataHandling;

namespace WeatherAPIProject.WeatherService
{
    public class CurrentWeather
    {
        // My instance of the call manager that manages the call to the API to get the data
        public WeatherCallManager weatherCallManager = new WeatherCallManager();

        // My instance of the DTO that transforms our data into the format of our model
        public CurrentWeatherDTO currentWeatherDTO = new CurrentWeatherDTO();

        // The Weather call of the City requested retrieved
        public String currentCity;

        // Weather converted to JObject so we manipulate later in useful methods
        public JObject json_weather;

        public CurrentWeather()
        {
            currentCity = weatherCallManager.GetCurrentWeather();
            currentWeatherDTO.DeserializeCurrentWeather(currentCity);
            json_weather = JsonConvert.DeserializeObject<JObject>(currentCity);
        }

        public bool WindCheck()
        {
            var Wind = currentWeatherDTO.CurrentWeather.wind.speed;
            if (Wind >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HumidityCheck()
        {
            var Humidity = currentWeatherDTO.CurrentWeather.main.humidity;
            if (Humidity >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TempCheck()
        {
            var Temp = currentWeatherDTO.CurrentWeather.main.humidity;
            if (Temp > -150)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CloudCheck()
        {
            var Clouds = currentWeatherDTO.CurrentWeather.clouds.all;
            if(Clouds >= 0)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}