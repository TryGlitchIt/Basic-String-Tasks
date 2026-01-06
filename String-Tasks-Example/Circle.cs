using System;

public class Kolo : Figura
{
    public double Promien { get; set; }

    public Kolo(double promien)
    {
        Promien = promien;
    }

    public override double ObliczPole() => Math.PI * Promien * Promien;
    public override double ObliczObwod() => 2 * Math.PI * Promien;
}
