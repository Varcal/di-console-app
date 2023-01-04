using DependencyInjectionConsoleApp.Services;
using Microsoft.Extensions.Configuration;

namespace DependencyInjectionConsoleApp
{
    public interface IMain
    {
        Task RunAsync();
    }

    public class Main : IMain
    {
        private readonly IConfiguration _configuration;
        private readonly ITestService _testService;

        public Main(IConfiguration confuguration, ITestService testService)
        {
            _configuration = confuguration;
            _testService = testService;
        }

        public async Task RunAsync()
        {
            var message = _configuration.GetSection("Message").Value;
            await _testService.ExecuteAsync();
            await _testService.ExecuteAsync(message);
        }
    }
}
