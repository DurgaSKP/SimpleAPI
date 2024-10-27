using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);
        [Fact]
        public void GetGetByName()
        {
           var returnval= controller.GetByName(27);
            // Assert - check that the summary is one of the expected values
            Assert.Contains(returnval.Value, WeatherForecastController.Summaries);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}