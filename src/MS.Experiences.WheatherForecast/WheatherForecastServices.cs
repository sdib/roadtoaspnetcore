using Microsoft.Practices.Unity;

namespace MS.Experiences.WheatherForecast
{
    public static class WheatherForecastServices
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IWheatherForecastService, MeteoFranceDataService>();
            unityContainer.RegisterType<IWheatherFactory, WheatherFactory>();
        }
    }
}
