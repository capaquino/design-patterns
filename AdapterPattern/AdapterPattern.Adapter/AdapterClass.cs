using System;
using AdapterPattern.Adaptee;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapter
{
    // Adapters are created for a specific class
    public class AdapterClass : ISomeInterface
    {
        private AdapteeClass adaptee;

        public AdapterClass(AdapteeClass a)
        {
            adaptee = a;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
