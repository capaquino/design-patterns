using System;
using System.IO;
using ProxyPattern.Clients;
using ProxyPattern.Interfaces;
using ProxyPattern.Proxies;

namespace ProxyPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Whip up a proxy. This has a Target, but note that it is not
            // instantiated here because it is "costly". (We are imagining it to
            // be costly for demonstration purposes. If we weren't using a 
            // proxy the ITarget would always be instantiated here which is
            // costly as stated before. There might also be a situation where
            // you aren't sure you're actually going to use the object and in
            // this situation you should only instantiate it if you're sure
            // your gonna use it (like right before you call its methods).

            ITarget proxy = new TargetProxy();
            // Lazy<TargetProxy> proxy = new Lazy<TargetProxy>(); // lazy version

            Console.WriteLine(
                "--- If lazy, proxy instantiated below. If not lazy, above ---");
            
            // Whip up a client
            Client client = new Client(proxy);
            // Client client = new Client(proxy.Value); // lazy version

            // Call the methods you want on your ITarget (which really go
            // through the proxy). Note Target is created here because we are
            // finally attempting to use it.
            client.UseTargetMethodThroughProxy();
            Console.WriteLine(Environment.NewLine);

            // Call it again, note Target is not created again.
            client.UseTargetMethodThroughProxy();
        }
    }
}
