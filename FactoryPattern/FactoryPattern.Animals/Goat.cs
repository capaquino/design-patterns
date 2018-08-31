using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Animals
{
    public class Goat : IAnimal
    {
        public Goat()
        {
        }

        public void AnimalNoise()
        {
            Console.WriteLine("Baahhhh");
        }
    }
}
