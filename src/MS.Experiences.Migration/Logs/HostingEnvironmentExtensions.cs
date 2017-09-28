namespace AF.AxaConnect.FrontOffice.Web.Infrastructure.Extensions
{
    using System.IO;
    using log4net.Config;
    using Microsoft.AspNetCore.Hosting;

    public static class HostingEnvironmentExtensions
    {
        public static void ConfigureLog4Net(this IHostingEnvironment hostingEnvironment, string configFileRelativePath)
        {
            string configFilePath = Path.Combine(hostingEnvironment.ContentRootPath, configFileRelativePath);
            if (!File.Exists(configFilePath))
            {
                throw new FileNotFoundException($"{configFilePath} is not found");
            }
            FileInfo configFileInfo = new FileInfo(configFilePath);
            XmlConfigurator.Configure(configFileInfo);
        }
    }
}
