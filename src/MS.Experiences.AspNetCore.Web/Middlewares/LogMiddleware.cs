using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MS.Experiences.Web.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<LogMiddleware> logger)
        {
            logger.LogWarning($"Received request on {context.Request.Path}");

            await this._next.Invoke(context);

            logger.LogWarning($"Sending response with status code {context.Response.StatusCode}");
        }
    }
}
