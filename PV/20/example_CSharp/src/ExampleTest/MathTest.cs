namespace ExampleTest;

using Example;

public class MathTest
{
    [Fact]
    public void TestSum()
    {
        Assert.Equal(2, Math.Sum(1, 1));        
        Assert.Equal(3, Math.Sum(2, 1));        
        Assert.Equal(4, Math.Sum(3, 1));        
        Assert.Equal(5, Math.Sum(4, 1));        
    }
}
