namespace AF.AxaConnect.Infrastructure.Logging
{
    using Microsoft.Extensions.Logging;

    internal class Log4NetLoggerProvider : ILoggerProvider
    {

        public ILogger CreateLogger(string categoryName)
        {
            return new Log4NetLogger(categoryName);
        }

        public void Dispose()
        {

        }
    }
}