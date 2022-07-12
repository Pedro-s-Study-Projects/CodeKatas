using System.ComponentModel;
using System.Linq;
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

public class FizzBuzzer
{
    private IComposer _composers =
        new ComposersThatOnlyTheFistApplies(
            new IComposer[]
            {
                new Fortizzz(),
                new ComposersThatAppend(new IComposer[] { new Fizz(), new Buzz(), new Puzz() })
            }
        );


    public string Apply(string value)
    {
        if (_composers.CanApply(value))
        {
            return _composers.Apply(value);
        }

        return value;
    }
}

public interface IComposer
{
    bool CanApply(string value);
    string Apply(string request);
}

public class Fizz : IComposer
{
    public bool CanApply(string value)
    {
        return int.Parse(value) % 3 == 0;
    }

    public string Apply(string request)
    {
        return "Fizz";
    }
}

public class Buzz : IComposer
{
    public bool CanApply(string value)
    {
        return int.Parse(value) % 5 == 0;
    }

    public string Apply(string request)
    {
        return "Buzz";
    }
}

public class Puzz : IComposer
{
    public bool CanApply(string value)
    {
        return int.Parse(value) % 7 == 0;
    }

    public string Apply(string request)
    {
        return "Puzz";
    }
}

public class Fortizzz : IComposer
{
    public bool CanApply(string value)
    {
        return int.Parse(value) % 40 == 0;
    }

    public string Apply(string request)
    {
        return "Fortyzzz";
    }
}

public class ComposersThatAppend : IComposer
{
    private IComposer[] _composers;


    public ComposersThatAppend(IComposer[] composers)
    {
        _composers = composers;
    }

    public bool CanApply(string value)
    {
        return _composers.Any((e) => e.CanApply(value));
    }

    public string Apply(string request)
    {
        var result = "";
        foreach (var composer in _composers)
        {
            if (composer.CanApply(request))
                result += composer.Apply(request);
        }

        return result;
    }
}

public class ComposersThatOnlyTheFistApplies : IComposer
{
    private IComposer[] _composers;


    public ComposersThatOnlyTheFistApplies(IComposer[] composers)
    {
        _composers = composers;
    }

    public bool CanApply(string value)
    {
        return _composers.Any((e) => e.CanApply(value));
    }

    public string Apply(string request)
    {
        foreach (var composer in _composers)
        {
            if (composer.CanApply(request))
                return composer.Apply(request);
        }

        return "";
    }
}