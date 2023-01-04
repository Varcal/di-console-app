using System.Threading.Tasks;

namespace DependencyInjectionConsoleApp.Services
{

    public interface ITestService
    {
        Task Execute();
    }


    public class TestService : ITestService
    {
        public async Task Execute()
        {
            _ = Task.Run(() =>
            {
                Console.WriteLine("Hello World!!!");
                Console.ReadKey();
            });  
        }
    }
}
