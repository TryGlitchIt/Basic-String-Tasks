public class Prostokat : Figura
{
    public double Dlugosc { get; set; }
    public double Szerokosc { get; set; }

    public Prostokat(double dlugosc, double szerokosc)
    {
        Dlugosc = dlugosc;
        Szerokosc = szerokosc;
    }

    public override double ObliczPole() => Dlugosc * Szerokosc;
    public override double ObliczObwod() => 2 * (Dlugosc + Szerokosc);
}
