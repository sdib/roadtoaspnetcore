using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MS.Experiences.Weather;
using MS.Experiences.Web.Controllers;

namespace MS.Experiences.Web.Tests
{
    [TestClass]
    public class WeatherForecastController_GetShould
    {
        private WeatherForecastController controller;
        private Mock<IWeatherForecastService> weatherService;
        private Mock<IWeatherDataServiceFactory> factory;

        [TestInitialize]
        public void BeforeEach()
        {
            weatherService = new Mock<IWeatherForecastService>();
            factory = new Mock<IWeatherDataServiceFactory>();
            controller = new WeatherForecastController(weatherService.Object, factory.Object);
        }

        [TestMethod]
        public void ReturnServiceData()
        {
            var serviceData = new WeatherForecast[0];
            weatherService.Setup(o => o.GetWeatherForecasts(1))
                .Returns(serviceData);

            IEnumerable<WeatherForecast> forecasts = controller.Get(1);

            Assert.AreSame(serviceData, forecasts);
        }
    }
}
