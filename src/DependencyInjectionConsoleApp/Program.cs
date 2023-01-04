using DependencyInjectionConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Run console app");
            await Host.CreateDefaultBuilder(args)
               .ConfigureServices(ConfigureServices)
               .ConfigureServices(services => services.AddSingleton<IMain, Main>())
               .Build()
               .Services.GetService<IMain>().RunAsync();
        }       

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
        }
    }
}