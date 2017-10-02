using Owin;

namespace MS.Experiences.Web.Middlewares
{
    public static class IAppBuilderExtensions
    {
        public static IAppBuilder UseLog(this IAppBuilder app)
        {
            return app.Use<LogMiddleware>();
        }
    }
}