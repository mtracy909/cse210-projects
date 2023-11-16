using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
        Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");
        fraction3.SetTop(2);
        fraction3.SetBottom(9);
        Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}