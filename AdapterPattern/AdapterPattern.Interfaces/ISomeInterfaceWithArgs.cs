using System;
namespace AdapterPattern.Interfaces
{
    // Say for instance the arguments in a library function (our target class)
    // are going to be changed at a later date, but we feel like being good
    // engineers and want to prepare for that ahead of time so we make an
    // adapter for the current version of that method (which will soon be
    // changed) that allows us to call it like the soon-to-be-released new
    // version of that method.
    public interface ISomeInterfaceWithArgs
    {
        // developers will switch it to this, currently is (string s, int n)
        // in the AdapteeClass
        void RequestWithArgs(int n, string s);
    }
}
