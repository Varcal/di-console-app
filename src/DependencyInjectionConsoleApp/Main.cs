using DependencyInjectionConsoleApp.Services;


namespace DependencyInjectionConsoleApp
{
    public interface IMain
    {
        Task RunAsync(string[] args);
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

        public async Task RunAsync(string[] args)
        {
            var message = _configuration.GetSection("Message").Value;
            await _testService.ExecuteAsync();


            foreach (var item in args)
            {
                await _testService.ExecuteAsync($"{message} = {item}");
            }
            
        }
    }
}
