using System;
using System.Configuration;

namespace MS.Experiences.Migration.Configuration
{
    public class LegacyConfigurationProvider : IConfigurationProvider
    {
        public WeatherConfig GetWeatherConfig()
        {
            return new WeatherConfig
            {
                TemperatureMin = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMinimum"]),
                TemperatureMax = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMaximum"])

            };
        }
    }
}