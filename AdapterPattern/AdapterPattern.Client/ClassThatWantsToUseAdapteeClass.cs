using System;
using AdapterPattern.Interfaces;
namespace AdapterPattern.Client
{
    // This guy one day wants to use the AdapteeClass, but Client only
    // allows objects implmenting ISomeInterface to be dependency injected
    // into it, and we can't change AdapteeClass to make it implement
    // ISomeInterface (because its a library/blackbox or something).
    // So we make an adapter specifically for AdapteeClass that can be 
    // consumed by Client.
    public class ClassThatWantsToUseAdapteeClass
    {
        private ISomeInterface something;

        public ClassThatWantsToUseAdapteeClass(ISomeInterface s)
        {
            something = s;
        }

        public void TheThingThatYouHaveAlwaysDoneButNowWantToDoWithAdaptee()
        {
            something.Request();
        }
    }
}
