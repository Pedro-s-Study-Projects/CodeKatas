using FizzBuzzApp;
using NUnit.Framework;

namespace TestProject1;

public class TestsBase
{
    [Test]
    public void Given1Returns1()
    {
        var result = new FizzBuzzer().Apply("1");
        Assert.AreEqual("1", result);
    }

    [Test]
    public void Given3ReturnsFizz()
    {
        var result = new FizzBuzzer().Apply("3");
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void Given5ReturnsBuzz()
    {
        var result = new FizzBuzzer().Apply("5");
        Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void Given7ReturnsPuzz()
    {
        var result = new FizzBuzzer().Apply("7");
        Assert.AreEqual("Puzz", result);
    }

    [Test]
    public void Given15ReturnsFizzBuzz()
    {
        var result = new FizzBuzzer().Apply("15");
        Assert.AreEqual("FizzBuzz", result);
    }

    [Test]
    public void Given105ReturnsFizzBuzzPuzz()
    {
        var result = new FizzBuzzer().Apply("105");
        Assert.AreEqual("FizzBuzzPuzz", result);
    }

    [Test]
    public void Given40ReturnsFortyzzz()
    {
        var result = new FizzBuzzer().Apply("40");
        Assert.AreEqual("Fortyzzz", result);
    }
    [Test]
    public void Given120ReturnsFortyzzz()
    {
        var result = new FizzBuzzer().Apply("120");
        Assert.AreEqual("Fortyzzz", result);
    }
}
