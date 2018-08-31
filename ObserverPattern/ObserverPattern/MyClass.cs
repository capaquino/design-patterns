using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Tea

        // Coffee
        IComponent coffee = new Coffee();
        Topping caramel = new Caramel(coffee);
        Topping espressoShot = new EspressoShot(caramel);

        // Outermost decorator must be called.
        // Wonder if there is a pattern where you call the innermost thing
        // and it propogates outward.
        Console.WriteLine("Your order of: " + espressoShot.Description() + "\n");
        Console.WriteLine("will be $" + espressoShot.Cost());
    }
}