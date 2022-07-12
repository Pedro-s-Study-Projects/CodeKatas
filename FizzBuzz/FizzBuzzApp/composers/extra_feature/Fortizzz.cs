namespace FizzBuzzApp;

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