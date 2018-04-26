using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using Xunit;

namespace IAmGroot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        //Groot
        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootWithQueryStringShouldReturnOkStatus()
        {
            //act
            var queryStringResponse = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, queryStringResponse.StatusCode);
        }

        //Yondu
        [Fact]
        public async Task GivingAParameterTheStatusIsOk()
        {
            //act
            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TheGivenResponeIsTheSameAsExpected()
        {
            //act
            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");
            Yondu yondu = JsonConvert.DeserializeObject<Yondu>(response.Content.ReadAsStringAsync().Result);

            //assert
            Assert.Equal(100.0, yondu.Distance);
        }

        [Fact]
        public async Task WithoutGivingAParameterTheStatusIsNotOk()
        {
            //act
            var response = await Client.GetAsync("/yondu");

            //assert
            Assert.NotEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TheGivenErrorResponeIsTheSameAsExpected() {

            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
