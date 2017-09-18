using Microsoft.Practices.Unity;

namespace MS.Exeriences.WheatherForecast
{
    public static class WheatherForecastServices
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IWheatherForecastService, MeteoFranceDataService>();
        }
    }
}
