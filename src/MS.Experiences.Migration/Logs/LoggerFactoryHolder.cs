using AF.AxaConnect.Infrastructure.Logging;
using Microsoft.Extensions.Logging;

namespace MS.Experiences.Web
{
    public static class LoggerFactoryHolder
    {
        private static LoggerFactory _loggerFactory;

        static LoggerFactoryHolder()
        {
            _loggerFactory = new LoggerFactory();
            _loggerFactory.AddLog4Net();
        }

        public static ILoggerFactory Instance => _loggerFactory;
    }
}