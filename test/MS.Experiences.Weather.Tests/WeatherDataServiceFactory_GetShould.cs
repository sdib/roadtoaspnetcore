using System;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MS.Experiences.Weather;

namespace MS.Experiences.WeatherTests
{
    [TestClass]
    public class WeatherDataServiceFactory_GetShould
    {
        private IWeatherDataServiceFactory factory;
        private Mock<IUnityContainer> unityContainer;
        private Mock<MeteoBelgiqueDataService> belgiqueService;
        private Mock<MeteoFranceDataService> franceService;

        [TestInitialize]
        public void BeforeEach()
        {
            belgiqueService = new Mock<MeteoBelgiqueDataService>();
            franceService = new Mock<MeteoFranceDataService>();

            unityContainer = new Mock<IUnityContainer>();

            unityContainer.Setup(o =>
                    o.Resolve(typeof(MeteoBelgiqueDataService), It.IsAny<string>(), It.IsAny<ResolverOverride[]>()))
                .Returns(belgiqueService.Object);

            unityContainer.Setup(o =>
                    o.Resolve(typeof(MeteoFranceDataService), It.IsAny<string>(), It.IsAny<ResolverOverride[]>()))
                .Returns(franceService.Object);

            factory = new WeatherDataServiceFactory(unityContainer.Object);
        }

        [TestMethod]
        public void ReturnBelgiqueDataService_WhenCountryIsBelgique()
        {
            IWeatherForecastService service = factory.Get("belgique");

            Assert.AreSame(belgiqueService.Object, service);
        }

        [TestMethod]
        public void ReturnFranceDataService_WhenCountryIsFrance()
        {
            IWeatherForecastService service = factory.Get("france");

            Assert.AreSame(franceService.Object, service);
        }

        [TestMethod, ExpectedException(typeof(NotSupportedException))]
        public void ThrowNotSupportedException_WhenCountryIsNotSupported()
        {
            factory.Get("suisse");
        }
    }
}
