using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS.Experiences.Weather;
using Newtonsoft.Json;

namespace MS.Experiences.WeatherTests
{
    [TestClass]
    public class MeteoBelgiqueDataService_GetWeatherForecastShould
    {
        private MeteoBelgiqueDataService _service;

        [TestInitialize]
        public void BeforeEach()
        {
            _service = new MeteoBelgiqueDataService();
        }

        [TestMethod]
        public void AlwaysReturnDataReadFromJsonDataSource()
        {
            string jsonData = Weather.Properties.Resources.meteo_belgium;
            WeatherForecast[] belgiumForecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(jsonData);

            IEnumerable<WeatherForecast> forecasts = _service.GetWeatherForecasts(5000);

            for (int i = 0; i < forecasts.Count(); i++)
            {
                var dataSourceForecast = belgiumForecasts.ElementAt(i);
                var resultForecast = forecasts.ElementAt(i);

                Assert.AreEqual(dataSourceForecast.TemperatureC, resultForecast.TemperatureC);
                Assert.AreEqual(dataSourceForecast.TemperatureF, resultForecast.TemperatureF);
                Assert.AreEqual(dataSourceForecast.Summary, resultForecast.Summary);
                Assert.AreEqual(dataSourceForecast.DateFormatted, resultForecast.DateFormatted);
            }
        }
    }
}