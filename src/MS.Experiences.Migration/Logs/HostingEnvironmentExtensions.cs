namespace AF.AxaConnect.FrontOffice.Web.Infrastructure.Extensions
{
    using System.Collections.Generic;
    using System.IO;
    using log4net;
    using log4net.Config;
    using Microsoft.AspNetCore.Hosting;

    public static class HostingEnvironmentExtensions
    {
        public static void ConfigureLog4Net(this IHostingEnvironment hostingEnvironment, string configFileRelativePath, IDictionary<string, string> globalProperties)
        {
            foreach (KeyValuePair<string, string> keyValuePair in globalProperties)
            {
                GlobalContext.Properties[keyValuePair.Key] = keyValuePair.Value;
            }

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
