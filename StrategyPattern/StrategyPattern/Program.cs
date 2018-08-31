using System;
using StrategyPattern.Client;
using StrategyPattern.Common;


namespace StrategyPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Composition Root, whipping up a few ducks.
            Duck elegantButLoudDuck = new Duck(new FlyElegantly(), new QuackLoudly());
            Duck shittyButQuietDuck = new Duck(new FlyShittily(), new QuackQuietly());

            elegantButLoudDuck.QuackWhileFlying();
            Console.WriteLine(Environment.NewLine);

            shittyButQuietDuck.QuackWhileFlying();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
