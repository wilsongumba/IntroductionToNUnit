namespace IntroductionToNUnit;

public class MyFirstNUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void PassingTest()
    {
        Console.WriteLine("Check the console");
        Assert.True(true);
        Console.WriteLine("Past the breakpoint");
    }

    [Test]
    public void FailingTest()
    {
        Assert.True(false);
    }
}
