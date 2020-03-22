using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPIProject.CurrentWeatherService;
using WeatherAPIProject.WeatherAPI.DataHandling;
using WeatherAPIProject.WeatherService;

namespace WeatherAPIProject.Test
{
    [TestFixture]
    public class CurrentWeatherTests
    {
        CurrentWeather _currentWeatherService = new CurrentWeather();

        public void CurrentWeatherStatusTest()
        {
            Assert.AreEqual(200,_currentWeatherService.currentWeatherDTO.CurrentWeather.cod);
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
    }
}
