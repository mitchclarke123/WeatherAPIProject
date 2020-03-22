using NUnit.Framework;
using WeatherAPIProject.WeatherService;


namespace WeatherAPIProject.Test
{
    [TestFixture]
    public class CurrentWeatherTests

    {
        CurrentWeather _currentWeatherService = new CurrentWeather();
        [Test]
        public void CurrentWeatherStatusTest()
        {
            Assert.AreEqual(200, _currentWeatherService.currentWeatherDTO.CurrentWeather.cod);
        }

        [Test]

        public void CountryIsCorrect()
        {
            Assert.AreEqual("GB", _currentWeatherService.currentWeatherDTO.CurrentWeather.sys.country);
        }

        [Test]

        public void LocationIsCorrect()
        {
            Assert.AreEqual("Tamworth", _currentWeatherService.currentWeatherDTO.CurrentWeather.name);
        }
        
        [Test]

        public void CloudsIsWorking()
        {
            CurrentWeather WC = new CurrentWeather();
            var result = WC.CloudCheck();
            Assert.AreEqual(true, result);
        }

        [Test]

        public void WindSpeedIsWorking()
        {
            CurrentWeather WC = new CurrentWeather();
            var result = WC.WindCheck();
            Assert.AreEqual(true, result);
        }

        [Test]

        public void HumidityIsWorking()
        {
            CurrentWeather WC = new CurrentWeather();
            var result = WC.HumidityCheck();
            Assert.AreEqual(true, result);
        }
        
        [Test]
        public void TempretureIsWorking()
        {
            CurrentWeather WC = new CurrentWeather();
            var result = WC.TempCheck();
            Assert.AreEqual(true, result);
        }
    }
}
