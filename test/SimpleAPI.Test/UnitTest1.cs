using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    TestController controller = new TestController();
    [Fact]
    public void GetReturnsWeather()
    {
        var returnVal = controller.Get();

        Assert.Equal("Hristo Dikov", returnVal);
    }


    [Fact]
    public void Test1()
    {

    }
}