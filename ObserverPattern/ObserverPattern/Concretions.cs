// Innermost Concretion

public class Coffee : IComponent
{
    public int Cost()
    {
        return 3;
    }

    public string Description()
    {
        return nameof(Coffee) + " with ";
    }
}

public class Tea : IComponent
{
    public int Cost()
    {
        return 2;
    }

    public string Description()
    {
        return nameof(Tea) + " with ";
    }
}

// Decorator Classes

public class Caramel : Topping
{
    public Caramel(IComponent i) : base(i)
    {
    }

    public override int Cost()
    {
        return component.Cost() + 1;
    }

    public override string Description()
    {
        return component.Description() + nameof(Caramel) + ", ";
    }
}

public class EspressoShot : Topping
{
    public EspressoShot(IComponent i) : base(i)
    {
    }

    public override int Cost()
    {
        return component.Cost() + 2;
    }

    public override string Description()
    {
        return component.Description() + nameof(EspressoShot) + ", ";
    }
}

// ... and infinite more toppings/modifiers

// so our simple Coffee or Tea is infinitely open to extension.