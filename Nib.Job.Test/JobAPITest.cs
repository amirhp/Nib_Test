using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;
using NIB_Test_Server.Controllers;
using NIB_Test_Server.DAL.Model;
using NIB_Test_Server.DAL.Services;
using Microsoft.AspNetCore.Mvc;
using NIB_Test_Server.DAL.Interfaces;

namespace NIB_Test_SNIB_Test_Server.Test
{
    public class JobAPITest
    {
        [Fact]
        public async Task GetJob_Return_Same_DataId()
        {
            // Arrange
            var mockRepository = new Mock<IJobRepository>();
            mockRepository.Setup(x => x.GetAsync().Result)
                .Returns(new List<Job>()
                {
                    new Job()
                    {
                        Id = 1,
                        Description = "Test"
                    }
                });

            var controller = new JobController(null, mockRepository.Object);

            // Act
            var result = await controller.GetAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test", result.First().Description);
        }


        [Fact]
        public async Task GetJob_Limit_Description_255_Length()
        {
            // Arrange
            var mockRepository = new Mock<IJobRepository>();
            mockRepository.Setup(x => x.GetAsync().Result)
                .Returns(new List<Job>()
                {
                    new Job()
                    {
                        Id = 1,
                        Description = new string('*', 500)
                    }
                });

            var controller = new JobController(null, mockRepository.Object);

            // Act
            var result = await controller.GetAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(255, result.First().Description.Length);
        }


        [Fact]
        public void GetJobById_Filter_Data_ById()
        {
            // Arrange
            var mockRepository = new Mock<IJobRepository>();
            mockRepository.Setup(x => x.GetJobById(1))
                .Returns(
                    new Job()
                    {
                        Id = 1,
                        Description = new string('*', 500)
                    }
                );

            var controller = new JobController(null, mockRepository.Object);

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.First().Id);
        }

    }
}
