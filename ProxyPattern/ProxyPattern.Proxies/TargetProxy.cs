using System;
using ProxyPattern.Interfaces;
using ProxyPattern.Targets;

namespace ProxyPattern.Proxies
{
    // This proxy can be used for anything implementing ITarget~
    public class TargetProxy : ITarget
    {
        private ITarget target;// = null;

        public TargetProxy()
        {
            Console.WriteLine("Proxy: I was instantiated!");
        }

        public void DoSomething()
        {
            if (target == null)
            {
                Console.WriteLine("Proxy: Instantiated a Target object!");
                target = new Target();
            }
            Console.WriteLine("Proxy: Calling ITarget.DoSomething()!");
            target.DoSomething();
        }
    }
}
