using Xunit;

namespace District09.Echo.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("OK", Routes.ReturnOk());
    }
}