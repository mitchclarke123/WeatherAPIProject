using RestSharp;

namespace WeatherAPIProject.WeatherAPI.HTTPManager
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
            var request = new RestRequest("/latest" + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

    }
}
