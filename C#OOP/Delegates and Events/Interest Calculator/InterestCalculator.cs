using System;

public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int years);

public class InterestCalculator
{
    private const int NumberOfInterestCompoundings = 12;
    private const int percents = 100;
    private decimal sumOfMoney;
    private decimal interest;
    private int years;
    private CalculateInterest type;

    public InterestCalculator(decimal sumOfMoney, decimal interest, int years, CalculateInterest type )
    {
        this.sumOfMoney = sumOfMoney;
        this.interest = interest;
        this.years = years;
        this.type = type;
    }

    public static decimal GetSimpleInterest(decimal sumOfMoney, decimal interest, int years)
    {
        return sumOfMoney * (1 + (interest / percents) * years);
    }

    public static decimal GetCompoundInterest(decimal sumOfMoney, decimal interest, int years)
    {
        return sumOfMoney * (decimal)Math.Pow((double)(1 + (interest / percents) / NumberOfInterestCompoundings), NumberOfInterestCompoundings* years);
    }

    public override string ToString()
    {
        return String.Format("{0:F4}", type(this.sumOfMoney, this.interest, this.years));
    }
}
 

