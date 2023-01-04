using DependencyInjectionConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using Moq;

namespace DependencyInjectionConsoleApp.Tests
{
    public class MainTests
    {
        private readonly Mock<IConfigurationSection> _configurationSection;
        private readonly Mock<IConfiguration> _configuration;
        private readonly Mock<ITestService> _testService;
        private readonly Main _main;

        public MainTests()
        {
            _configurationSection = new Mock<IConfigurationSection>();
            _configurationSection.Setup(x => x.Value).Returns("Some message");

            _configuration = new Mock<IConfiguration>();
            _configuration.Setup(x => x.GetSection(It.Is<string>(k => k == "Message"))).Returns(_configurationSection.Object);

            _testService = new Mock<ITestService>();
            _main = new Main(_configuration.Object,  _testService.Object);
        }

        [Fact]
        public async Task RunAsyncSuccess()
        {
            _testService.Setup(x => x.ExecuteAsync());

            await _main.RunAsync();

            _testService.VerifyAll();
        }

    }
}