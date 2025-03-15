using Domain.DTOs;
using Domain.Interfaces;
using Infraestructure_.Services;
using Moq;
using Requestor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ChuckNorrisServiceTests
    {
        private readonly Mock<IRequestorService> _requestorServiceMock;
        private readonly IChuckNorrisService _chuckNorrisService;

        public ChuckNorrisServiceTests()
        {
            _requestorServiceMock = new Mock<IRequestorService>();
            _chuckNorrisService = new ChuckNorrisService(_requestorServiceMock.Object);
        }

        [Fact]
        public async Task GetRandomJoke_ReturnsSuccess_WhenRequestIsSuccessful()
        {
            // Arrange
            var mockResponse = new ApiResponse<string>
            {
                Success = true,
                Data = "{\"value\": \"Chuck Norris jokes are the best!\"}",
                Message = "Success",
                StatusCode = 200
            };

            _requestorServiceMock
                .Setup(r => r.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(mockResponse);

            // Act
            var result = await _chuckNorrisService.GetRandomJoke();

            // Assert
            Assert.True(result.Success);
            Assert.Equal("Success", result.Message);
            Assert.NotNull(result.Data);
            Assert.Equal(typeof(ChuckNorrisDTO), result.Data.GetType());
            Assert.Equal("Chuck Norris jokes are the best!", result.Data?.value);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task GetRandomJoke_ReturnsFailure_WhenRequestFails()
        {
            // Arrange
            var mockResponse = new ApiResponse<string>
            {
                Success = false,
                Message = "Error",
                StatusCode = 500,
            };

            _requestorServiceMock
                .Setup(r => r.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(mockResponse);

            // Act
            var result = await _chuckNorrisService.GetRandomJoke();

            // Assert
            Assert.False(result.Success);
            Assert.Equal("Error", result.Message);
            Assert.NotNull(result.Data);
            Assert.Equal(typeof(ChuckNorrisDTO), result.Data.GetType());
            Assert.Equal(500, result.StatusCode);

        }
    }
}
