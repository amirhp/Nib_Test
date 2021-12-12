using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;
using NIB_Test_Server.Controllers;
using NIB_Test_Server.DAL.Model;
using NIB_Test_Server.DAL.Interfaces;
using NIB_Test_Server.DAL.Services;

namespace NIB_Test_SNIB_Test_Server.Test
{
    public class LocationAPITest
    {

        [Fact]
        public async Task GetLocation_Fetch_Data()
        {
            var configurationSectionMock = new Mock<IConfigurationSection>();
            var configurationMock = new Mock<IConfiguration>();

            configurationSectionMock
                .Setup(x => x.Value)
                .Returns("https://private-8dbaa-nibdevchallenge.apiary-mock.com/");

            configurationMock
                .Setup(x => x.GetSection("ApiLocation"))
                .Returns(configurationSectionMock.Object);

            var locationRepository = new LocationRepository(configurationMock.Object);

            // Arrange
            var controller = new LocationController(null, locationRepository);

            // Act
            var result = await controller.GetAsync();

            // Assert
            Assert.NotEmpty(result);
        }


        [Fact]
        public async Task GetLocation_Return_Repository_Data()
        {
            // Arrange
            var mockRepository = new Mock<ILocationRepository>();
            mockRepository.Setup(x => x.GetAsync().Result)
                .Returns(
                    new List<Location>()
                    {
                        new Location()
                        {
                            Id = 1,
                            Name = "Auckland",
                            State = "Auckland"
                        }
                    }
                );

            var controller = new LocationController(null, mockRepository.Object);

            // Act
            var result = await controller.GetAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.First().Id);
        }


    }
}
