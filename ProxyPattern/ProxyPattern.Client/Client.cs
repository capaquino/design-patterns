using System;
using ProxyPattern.Interfaces;

namespace ProxyPattern.Clients
{
    public class Client
    {
        private ITarget target;

        public Client(ITarget t)
        {
            target = t;
        }

        public void UseTargetMethodThroughProxy()
        {
            Console.WriteLine("Client: Calling ITarget.DoSomething()!");
            target.DoSomething();
        }
    }
}
