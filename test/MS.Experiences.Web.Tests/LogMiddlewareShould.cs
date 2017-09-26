using System.Net.Http;
using System.Threading.Tasks;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MS.Experiences.Web.Middlewares;
using Microsoft.Owin.Testing;
using Owin;

namespace MS.Experiences.Web.Tests
{
    [TestClass]
    public class LogMiddlewareShould
    {
        private const int ResponseStatusCode = 200;
        private Mock<ILog> log;
        private TestServer testServer;

        [TestInitialize]
        public void BeforeEach()
        {
            log = new Mock<ILog>();
            testServer = TestServer.Create(builder =>
            {
                builder.UseLog(log.Object);
                builder.Run(context =>
                {
                    context.Response.StatusCode = ResponseStatusCode;
                    return Task.FromResult(0);
                });
            });
        }

        [TestCleanup]
        public void AfterEach()
        {
            testServer.Dispose();
        }

        [TestMethod]
        public async Task LogRequestPath()
        {
            const string requestPath = "/myrequest";

            HttpResponseMessage responseMessage = await testServer.CreateRequest(requestPath).GetAsync();

            log.Verify(o => o.Debug(It.Is<string>(message => message == $"Received request on {requestPath}")));
        }

        [TestMethod]
        public async Task LogResponseStatusCode()
        {
            HttpResponseMessage responseMessage = await testServer.CreateRequest("/").GetAsync();

            log.Verify(o => o.Debug(It.Is<string>(message => message == $"Sending response with status code {ResponseStatusCode}")));
        }
    }
}
