using System;
using ProxyPattern.Interfaces;

namespace ProxyPattern.Targets
{
    public class Target : ITarget
    {
        public Target()
        {
            Console.WriteLine("Target: I was instantiated!");
        }

        public void DoSomething()
        {
            Console.WriteLine("Target: DoSomething() was called!");
        }
    }
}
