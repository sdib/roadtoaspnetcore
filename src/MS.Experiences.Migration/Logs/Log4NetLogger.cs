namespace AF.AxaConnect.Infrastructure.Logging
{
    using System;
    using log4net;
    using Microsoft.Extensions.Logging;

    public class Log4NetLogger : ILogger
    {
        private readonly Lazy<ILog> logger;

        public Log4NetLogger(string loggerName)
        {
            logger = new Lazy<ILog>(() => LogManager.GetLogger(loggerName));
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Critical:
                    return logger.Value.IsFatalEnabled;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    return logger.Value.IsDebugEnabled;
                case LogLevel.Error:
                    return logger.Value.IsErrorEnabled;
                case LogLevel.Information:
                    return logger.Value.IsInfoEnabled;
                case LogLevel.Warning:
                    return logger.Value.IsWarnEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(logLevel));
            }
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            if (formatter == null)
            {
                throw new ArgumentNullException(nameof(formatter));
            }

            string message = formatter(state, exception);

            if (!string.IsNullOrEmpty(message)
                || exception != null)
            {
                switch (logLevel)
                {
                    case LogLevel.Critical:
                        logger.Value.Fatal(message);
                        break;
                    case LogLevel.Debug:
                    case LogLevel.Trace:
                        logger.Value.Debug(message);
                        break;
                    case LogLevel.Error:
                        logger.Value.Error(message);
                        break;
                    case LogLevel.Information:
                        logger.Value.Info(message);
                        break;
                    case LogLevel.Warning:
                        logger.Value.Warn(message);
                        break;
                    default:
                        logger.Value.Error($"Encountered unknown log level {logLevel}, writing out as Info.");
                        logger.Value.Info(message, exception);
                        break;
                }
            }
        }
    }
}