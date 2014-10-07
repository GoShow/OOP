using System;
using System.Data;

public class InterestCalculatorTester
{
    static void Main()
    {
        CalculateInterest compound = InterestCalculator.GetCompoundInterest;
        CalculateInterest simple = InterestCalculator.GetSimpleInterest;
        InterestCalculator compoundInterestCalculator = new InterestCalculator(500m, 5.6m, 10, compound);
        InterestCalculator simpleInterestCalculator = new InterestCalculator(2500m, 7.2m, 15, simple);

        Console.WriteLine(simpleInterestCalculator);
        Console.WriteLine(compoundInterestCalculator);
    }

   

    
}

