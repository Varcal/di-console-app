using DependencyInjectionConsoleApp.Services;


namespace DependencyInjectionConsoleApp
{
    public interface IMain
    {
        Task RunAsync();
    }

    public class Main : IMain
    {
        private readonly ITestService _testService;

        public Main(ITestService testService)
        {
            _testService = testService;
        }

        public async Task RunAsync()
        {
            await _testService.Execute();
        }
    }
}
