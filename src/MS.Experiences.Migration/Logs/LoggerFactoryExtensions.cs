using System.IO;
using log4net.Config;

namespace AF.AxaConnect.Infrastructure.Logging
{
    using Microsoft.Extensions.Logging;

    public static class LoggerFactoryExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddProvider(new Log4NetLoggerProvider());
            return loggerFactory;
        }

        public static ILoggerFactory AddLog4Net(this ILoggerFactory loggerFactory, string configPath)
        {
            XmlConfigurator.Configure(new FileInfo(configPath));
            loggerFactory.AddProvider(new Log4NetLoggerProvider());
            return loggerFactory;
        }
    }
}