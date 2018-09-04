using System;
using AdapterPattern.Interfaces;
namespace AdapterPattern.Client
{
    public class ClassThatWantsToUseNewArgumentOrder
    {
        private ISomeInterfaceWithArgs something;

        public ClassThatWantsToUseNewArgumentOrder(ISomeInterfaceWithArgs s)
        {
            something = s;
        }

        // New argument order will be (int, string).
        public void TheMethodYouWantToCallButWithFutureSyntax(int n, string s)
        {
            Console.WriteLine(
                "Client: SpecificRequestWithArgs({0},{1}) of AdapteeClass called!", n, s);
            something.RequestWithArgs(n,s);
        }
    }
}
