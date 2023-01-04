using System.Threading.Tasks;

namespace DependencyInjectionConsoleApp.Services
{

    public interface ITestService
    {
        Task ExecuteAsync();
        Task ExecuteAsync(string message);
    }


    public class TestService : ITestService
    {
        public async Task ExecuteAsync()
        {
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
