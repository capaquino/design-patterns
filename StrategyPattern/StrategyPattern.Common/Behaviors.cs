using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Common
{
    /* Strategy A */

    // Behavior 1
    public class QuackLoudly : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quacking Loudly !!!");
        }
    }

    // Behavior 2
    public class QuackQuietly : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quacking Quietly ...");
        }
    }

    /* Strategy B */

    // Behavior 1
    public class FlyElegantly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying Elegantly");
        }
    }

    // Behavior 2
    public class FlyShittily : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying Shittily ^^^\\-0.0-/^^^");
        }
    }

}
