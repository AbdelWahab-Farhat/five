namespace AdvancedApp.Tests;
using Xunit;

public class CubesTests
{
    [Fact]
    public void CubeInputReturn27()
    {
        int number = 3;
        double expected = 27;
        double result = Program.Cube(number);

        Assert.Equal(expected, result);
        
    }
}
