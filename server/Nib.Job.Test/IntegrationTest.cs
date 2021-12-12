using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Moq;
using NIB_Test_Server;
using Xunit;
using NIB_Test_Server.Controllers;
using NIB_Test_Server.DAL.Model;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Services;

namespace NIB_Test_SNIB_Test_Server.Test
{
    public class IntegrationTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public IntegrationTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task Return_Ok_When_GetJob()
        {
            HttpResponseMessage response = await _client.GetAsync("/job/");
            Assert.True(response.IsSuccessStatusCode);
        }



        [Fact]
        public async Task Return_Ok_When_GetLocation()
        {
            HttpResponseMessage response = await _client.GetAsync("/location/");
            Assert.True(response.IsSuccessStatusCode);
        }


    }
}
