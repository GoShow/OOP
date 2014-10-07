using System;

public class Frog : Animal, ISound
{
    public Frog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine(" make some nooooooooooooise!");
    }
}

