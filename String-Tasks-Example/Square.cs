public class Kwadrat : Figura
{
    public double Bok { get; set; }

    public Kwadrat(double bok)
    {
        Bok = bok;
    }

    public override double ObliczPole() => Bok * Bok;
    public override double ObliczObwod() => 4 * Bok;
}
