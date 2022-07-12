namespace FizzBuzzApp;

public interface IComposer
{
    bool CanApply(string value);
    string Apply(string request);
}