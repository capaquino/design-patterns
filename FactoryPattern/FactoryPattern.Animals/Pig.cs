using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Animals
{
    public class Pig : IAnimal
    {
        public Pig()
        {
        }

        public void AnimalNoise()
        {
            Console.WriteLine("Oink oink");
        }
    }
}
