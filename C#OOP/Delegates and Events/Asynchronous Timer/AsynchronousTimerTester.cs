
using System;
using System.Threading;
public class TestTimer
{
    public static void PrintTicksLeft(string str)
    {
        Console.WriteLine("\n{0} ticks left", str);
    }
    
    static void Main()
    {
        AsynchronousTimer timer = new AsynchronousTimer(PrintTicksLeft, 1000, 10);
        timer.Start();
        Console.WriteLine("You can enter text, while this timer is running.\nIf you hit enter the program will stop.");
        Console.ReadLine();
        timer.Stop();

    }
}