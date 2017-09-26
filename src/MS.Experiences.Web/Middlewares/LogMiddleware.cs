using log4net;
using Microsoft.Owin;
using System.Threading.Tasks;

namespace MS.Experiences.Web.Middlewares
{
    public class LogMiddleware : OwinMiddleware
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(LogMiddleware));

        public LogMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public LogMiddleware(OwinMiddleware next, ILog log)
            : this(next)
        {
            this.log = log;
        }

        public async override Task Invoke(IOwinContext context)
        {
            log.Debug($"Received request on {context.Request.Path}");

            await this.Next.Invoke(context);

            log.Debug($"Sending response with status code {context.Response.StatusCode}");
        }
    }
}
