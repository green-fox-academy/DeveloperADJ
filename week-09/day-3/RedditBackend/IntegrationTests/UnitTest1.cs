using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RedditBackend;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task Test1()
        {
            var response = await Client.GetAsync("/");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
