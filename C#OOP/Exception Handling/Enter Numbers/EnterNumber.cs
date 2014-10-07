using System;
class Program
{
    
    static void Main()
    {
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }
    static int ReadNumber(int start, int end)
    {
        int number = 0;

        try
        {

            Console.Write("Enter number {0} < your number < {1}: ", start, end);
            number = int.Parse(Console.ReadLine());
            if (!(start < number && number < end))
            {
                while (!(start < number && number < end))
                {
                    Console.WriteLine("Your number is not in range {0} - {1} !", start, end);
                    Console.Write("Enter number {0} < your number < {1}: ", start, end);
                    number = int.Parse(Console.ReadLine());
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
            throw;
        }

        return number;
    }
}