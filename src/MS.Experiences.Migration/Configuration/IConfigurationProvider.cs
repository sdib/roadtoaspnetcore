namespace MS.Experiences.Migration.Configuration
{
    public interface IConfigurationProvider
    {
        WeatherConfig GetWeatherConfig();
    }

    public class WeatherConfig
    {
        public int TemperatureMax { get; set; }
        public int TemperatureMin { get; set; }
    }
}
