using System;

class FractionsTester
{
    static void Main()
    {
        Fraction f1 = new Fraction(22, 7);
        Fraction f2 = new Fraction(40, 4);
        Fraction result = f1 + f2;

        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);

        result = f1 - f2;

        Console.WriteLine();
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);
    }
}

