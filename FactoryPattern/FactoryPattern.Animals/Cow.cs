using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Animals
{
    public class Cow : IAnimal
    {
        public Cow()
        {
        }

        public void AnimalNoise()
        {
            Console.WriteLine("Moooooo");
        }
    }
}
