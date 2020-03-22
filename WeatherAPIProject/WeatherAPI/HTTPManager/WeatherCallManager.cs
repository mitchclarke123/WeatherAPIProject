using RestSharp;
using WeatherAPIProject;

// only need one of these

namespace WeatherAPIProject.CurrentWeatherService.HTTPManager
{
    public class WeatherCallManager
    {
        private readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather()
        {
            var request = new RestRequest("weather?q=Tamworth&appid=" + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }


        // add new methods for each differnt API call (may use parameters)
    }
}
