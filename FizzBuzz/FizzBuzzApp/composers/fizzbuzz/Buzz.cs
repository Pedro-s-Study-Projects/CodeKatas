namespace FizzBuzzApp;

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