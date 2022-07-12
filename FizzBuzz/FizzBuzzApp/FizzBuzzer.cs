using FizzBuzzApp.Composers;
using FizzBuzzApp.Composers.ExtraFeature;
using FizzBuzzApp.Composers.FizzBuzzPuzz;

namespace FizzBuzzApp;

public class FizzBuzzer
{
    private IComposer _composers =
        new ComposersThatOnlyTheFistToBeAbleToApplies(
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