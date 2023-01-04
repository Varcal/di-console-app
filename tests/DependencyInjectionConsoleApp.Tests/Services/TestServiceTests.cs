using DependencyInjectionConsoleApp.Services;
using Moq;

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
                await testService.ExecuteAsync();
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
            
        }


        [Fact]
        public async Task ExecuteWithMessageSuccess()
        {
            try
            {
                var testService = new TestService();
                await testService.ExecuteAsync(It.IsAny<string>());
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }

        }
    }
}
