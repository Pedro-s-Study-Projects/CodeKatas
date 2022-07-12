namespace FizzBuzzApp;

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