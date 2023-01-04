using DependencyInjectionConsoleApp.Services;
using Moq;

namespace DependencyInjectionConsoleApp.Tests
{
    public class MainTests
    {
        private readonly Mock<ITestService> _testService;
        private readonly Main _main;

        public MainTests()
        {
            _testService = new Mock<ITestService>();
            _main = new Main(_testService.Object);
        }

        [Fact]
        public async Task RunAsyncSuccess()
        {
            _testService.Setup(x => x.Execute());


            await _main.RunAsync();

            _testService.VerifyAll();
        }
    }
}