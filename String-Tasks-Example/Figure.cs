public abstract class Figura
{
    public abstract double ObliczPole();
    public abstract double ObliczObwod();

    public virtual void WypiszDane()
    {
        Console.WriteLine($"Pole: {ObliczPole()}, Obwód: {ObliczObwod()}");
    }
}
