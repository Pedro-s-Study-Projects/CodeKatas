namespace FizzBuzzApp;

public class ComposersThatOnlyTheFistToBeAbleToApplies : IComposer
{
    private IComposer[] _composers;


    public ComposersThatOnlyTheFistToBeAbleToApplies(IComposer[] composers)
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