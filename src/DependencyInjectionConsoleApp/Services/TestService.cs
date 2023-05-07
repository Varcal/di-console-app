using Microsoft.Extensions.Logging;

namespace DependencyInjectionConsoleApp.Services
{

    public interface ITestService
    {
        Task ExecuteAsync();
        Task ExecuteAsync(string message);
    }


    public class TestService : ITestService
    {
        private readonly ILogger<TestService> _logger;

        public TestService(ILogger<TestService> logger)
        {
            _logger= logger;
        }

        public async Task ExecuteAsync()
        {
            _logger.LogInformation("Iniciando o Job");
            await Task.Run(() =>
            {
                Console.WriteLine("Hello World!!!");
            });
        }

        public async Task ExecuteAsync(string message)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(message);
                
            });
        }
    }
}
