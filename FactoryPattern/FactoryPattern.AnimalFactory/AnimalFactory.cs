using System;
using FactoryPattern.Animals;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories
{
    public class AnimalFactory
    {
        public AnimalFactory()
        {
            
        }

        // How about functionality to balance how many of each animal we have?
        // Keeping ints for each type of animal is a bad idea because it
        // scales terribly. If you had 100 different kinds of animals, you would
        // need 100 int members and the balancing algorithm would be ass. Think
        // about how to do this in a way that scales if you get some free time.
        public IAnimal GetAnimal(string which)
        {
            which.ToLower();
            switch (which)
            {
                case "goat": return new Goat();
                case "pig": return new Pig();
                case "cow": return new Cow();
                default: return null;
            }
        }
    }
}
