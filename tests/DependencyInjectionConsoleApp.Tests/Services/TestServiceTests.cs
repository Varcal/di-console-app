using DependencyInjectionConsoleApp.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace DependencyInjectionConsoleApp.Tests.Services
{
    public class TestServiceTests
    {
        private readonly Mock<ILogger<TestService>> _logger;
        private readonly TestService _testService;

        public TestServiceTests()
        {
            _logger= new Mock<ILogger<TestService>>();
            _testService = new TestService(_logger.Object);
        }

        [Fact]
        public async Task ExecuteSuccess()
        {
            try
            {
                await _testService.ExecuteAsync();
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
            
        }


        [Fact]
        public async Task ExecuteWithMessageSuccess()
        {
            try
            {
                await _testService.ExecuteAsync(It.IsAny<string>());
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }

        }
    }
}
