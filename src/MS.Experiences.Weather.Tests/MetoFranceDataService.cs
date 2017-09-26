using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS.Experiences.Weather;

namespace MS.Experiences.WeatherTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetWeatherForecastsShouldReturn5Element()
        {
            var meteoFranceDataService = new MeteoFranceDataService();

            var wheatherForecasts = meteoFranceDataService.GetWeatherForecasts(5);
            var count = wheatherForecasts.Count();

            Assert.AreEqual(count, 5);
        }
    }
}
