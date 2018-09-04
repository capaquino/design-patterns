using System;
using AdapterPattern.Adaptee;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapter
{
    public class MethodSigAdapterClass : ISomeInterfaceWithArgs
    {
        private AdapteeClass adaptee;

        public MethodSigAdapterClass(AdapteeClass a)
        {
            adaptee = a;
        }

        public void RequestWithArgs(int n, string s)
        {
            // Notice n and s are flipped to match the current version.
            adaptee.SpecificRequestWithArgs(s, n);
        }
    }
}
