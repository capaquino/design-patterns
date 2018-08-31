public interface IComponent
{
    int Cost();
    string Description();
}



// Can decorator also be an interface?
// - Yes but you would need to implement the same constructor
// - for every single decorator you create.
public abstract class Topping : IComponent
{
    protected IComponent component;
    public Topping(IComponent i)
    {
        component = i;
    }

    // override these
    public abstract int Cost();
    public abstract string Description();
}