using DependencyInjectionConsoleApp.Services;


namespace DependencyInjectionConsoleApp.Tests.Services
{
    public class TestServiceTests
    {
        [Fact]
        public async Task ExecuteSuccess()
        {
            try
            {
                var testService = new TestService();
                await testService.Execute();
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
            
        }
    }
}
