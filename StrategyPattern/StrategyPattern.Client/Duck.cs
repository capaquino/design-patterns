using System;
using StrategyPattern.Interfaces;
namespace StrategyPattern.Client
{
    public class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        // Constructor Injection
        public Duck(IFlyBehavior fb, IQuackBehavior qb)
        {
            _flyBehavior = fb;
            _quackBehavior = qb;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void QuackWhileFlying()
        {
            _quackBehavior.Quack();
            _flyBehavior.Fly();
        }
    }
}
