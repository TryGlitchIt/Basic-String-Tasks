using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StringTasks.GetMiddle("Programowanie"));
        Console.WriteLine(StringTasks.ReverseWords("Akademia Ekonomiczno Humanistyczna w Warszawie"));
        Console.WriteLine(StringTasks.CamelToKebab("dlugaNazwaPewnejZmiennej"));
        Console.WriteLine(StringTasks.KebabToCamel("dluga-nazwa-pewnej-zmiennej"));

        StringTasks.BuildWithString();
        StringTasks.BuildWithStringBuilder();

        Figura[] figury = {
            new Prostokat(4, 6),
            new Kwadrat(5),
            new Kolo(3)
        };

        foreach (var figura in figury)
        {
            figura.WypiszDane();
        }
    }
}
