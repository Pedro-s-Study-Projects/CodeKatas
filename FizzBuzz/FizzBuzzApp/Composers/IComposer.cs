namespace FizzBuzzApp.Composers;

public interface IComposer
{
    bool CanApply(string value);
    string Apply(string request);
}