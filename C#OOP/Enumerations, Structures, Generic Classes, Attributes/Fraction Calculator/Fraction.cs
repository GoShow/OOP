using System;
public struct Fraction
{
    public Fraction(long numerator, long denominator) : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }
    public long Numerator { get; set; }
    public long Denominator { get; set; }

    public override string ToString()
    {
        return (decimal)Numerator / Denominator + "";
    }

    public static Fraction operator +(Fraction a, Fraction b){
        
        long numerator;
        long denominator;
        
        long greatestCommonDividor = Fraction.CalcGreatestCommonDividor(a.Denominator, b.Denominator);
        denominator = greatestCommonDividor;
        numerator = a.Numerator * (denominator / a.Denominator) + b.Numerator * (denominator / b.Denominator);

        return new Fraction(numerator, denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {

        long numerator;
        long denominator;

        long greatestCommonDividor = Fraction.CalcGreatestCommonDividor(a.Denominator, b.Denominator);
        denominator = greatestCommonDividor;
        numerator = a.Numerator * (denominator / a.Denominator) - b.Numerator * (denominator / b.Denominator);

        return new Fraction(numerator, denominator);
    }
    private static long CalcGreatestCommonDividor(long a, long b)
    {
        long num1, num2;
        if (a > b)
        {
            num1 = a;
            num2 = b;
        }
        else
        {
            num1 = b;
            num2 = a;
        }

        for (int i = 1; i <= num2; i++)
        {
            if ((num1 * i) % num2 == 0)
            {
                return i * num1;
            }
        }
        return num2;
    }
}

