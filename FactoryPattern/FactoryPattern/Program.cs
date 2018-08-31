using System;
using FactoryPattern.Factories;

namespace FactoryPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();

            while (true)
            {
                // Add some animals to the pen.
                string input = Console.ReadLine();
                var animal = factory.GetAnimal(input);
                if (animal == null)
                    break;
                animal.AnimalNoise();
            }
        }
    }
}
