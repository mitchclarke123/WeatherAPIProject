using WeatherAPIProject;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPIProject.CurrentWeatherService.HTTPManager;
using WeatherAPIProject.CurrentWeatherSerice.DataHnadling;

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


    }

}