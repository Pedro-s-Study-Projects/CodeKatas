namespace FizzBuzzApp;

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