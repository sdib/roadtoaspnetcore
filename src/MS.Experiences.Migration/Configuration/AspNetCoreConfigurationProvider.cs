using Microsoft.Extensions.Options;

namespace MS.Experiences.Migration.Configuration
{
    public class AspNetCoreConfigurationProvider : IConfigurationProvider
    {
        private readonly IOptions<WeatherConfig> _weatherConfig;

        public AspNetCoreConfigurationProvider(IOptions<WeatherConfig> weatherConfig)
        {
            _weatherConfig = weatherConfig;
        }

        public WeatherConfig GetWeatherConfig()
        {
            return _weatherConfig.Value;
        }
    }
}