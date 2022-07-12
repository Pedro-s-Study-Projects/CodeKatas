namespace FizzBuzzApp.Composers.FizzBuzzPuzz;

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