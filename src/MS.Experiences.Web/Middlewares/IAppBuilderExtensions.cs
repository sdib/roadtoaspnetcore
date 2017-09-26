using log4net;
using Owin;

namespace MS.Experiences.Web.Middlewares
{
    public static class IAppBuilderExtensions
    {
        public static IAppBuilder UseLog(this IAppBuilder app)
        {
            return app.Use<LogMiddleware>();
        }

        public static IAppBuilder UseLog(this IAppBuilder app, ILog log)
        {
            return app.Use<LogMiddleware>(log);
        }
    }
}