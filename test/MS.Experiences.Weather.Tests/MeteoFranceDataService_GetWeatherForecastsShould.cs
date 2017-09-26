using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS.Experiences.Weather;

namespace MS.Experiences.WeatherTests
{
    [TestClass]
    public class MeteoFranceDataService_GetWeatherForecastsShould
    {
        private MeteoFranceDataService _service;

        [TestInitialize]
        public void BeforeEach()
        {
            _service = new MeteoFranceDataService();
        }

        [TestMethod]
        public void ReturnFiveElements()
        {
            var forecasts = _service.GetWeatherForecasts(15);

            Assert.AreEqual(forecasts.Count(), 5);
        }

        [TestMethod]
        public void ReturnForecastForNextFiveDays()
        {
            var forecasts = _service.GetWeatherForecasts(0);

            Assert.AreEqual(DateTime.Now.AddDays(1).ToShortDateString(), forecasts.First().DateFormatted);
            Assert.AreEqual(DateTime.Now.AddDays(2).ToShortDateString(), forecasts.ElementAt(1).DateFormatted);
            Assert.AreEqual(DateTime.Now.AddDays(3).ToShortDateString(), forecasts.ElementAt(2).DateFormatted);
            Assert.AreEqual(DateTime.Now.AddDays(4).ToShortDateString(), forecasts.ElementAt(3).DateFormatted);
            Assert.AreEqual(DateTime.Now.AddDays(5).ToShortDateString(), forecasts.Last().DateFormatted);
        }
    }
}
