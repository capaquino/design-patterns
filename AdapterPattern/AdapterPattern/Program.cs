using System;
using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Client;
using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Whip up the target
            AdapteeClass target = new AdapteeClass();

            // Whip up the adapter for the target
            ISomeInterface clientToTargetAdapter = new AdapterClass(target);

            // Whip up the client that was not able to inject the target class
            // before but now can thanks to the clientToTarget_adapter.
            ClassThatWantsToUseAdapteeClass client = 
                new ClassThatWantsToUseAdapteeClass(clientToTargetAdapter);

            client.TheThingThatYouHaveAlwaysDoneButNowWantToDoWithAdaptee();

            // voila, and you didn't change the code for your Client class or
            // your AdapteeClass class (if you were even able to in the first
            // place).

            // Example where we prepare for a future version of the Adaptee
            // where the method signature of a method we are using in that
            // library is going to change. So we change to the new method
            // signature prematurely using an Adapter.

            // Already have an AdapteeClass

            // Whip up the adapter that swaps the method signature
            ISomeInterfaceWithArgs methodSigAdapter = 
                new MethodSigAdapterClass(target);

            ClassThatWantsToUseNewArgumentOrder client2 =
                new ClassThatWantsToUseNewArgumentOrder(methodSigAdapter);

            // Calling with new syntax
            client2.TheMethodYouWantToCallButWithFutureSyntax(5, "hi");
        }
    }
}

