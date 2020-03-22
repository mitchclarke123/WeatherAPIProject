using RestSharp;
// only need one of these
namespace FrameworkCreation.FixerLatestService.HTTPManager
{
    public class WeatherCallManager
    {
        private readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetLatestRates()
        {
            var request = new RestRequest("/latest" + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        // add new methods for each differnt API call (may use parameters)
    }
}
