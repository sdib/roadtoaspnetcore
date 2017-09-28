using Microsoft.AspNetCore.Builder;

namespace MS.Experiences.Web.Middlewares
{
    public static class IAppBuilderExtensions
    {
        public static IApplicationBuilder UseLog(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogMiddleware>();
        }
        
    }
}