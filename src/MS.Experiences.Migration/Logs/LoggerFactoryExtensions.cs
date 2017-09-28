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
    }
}