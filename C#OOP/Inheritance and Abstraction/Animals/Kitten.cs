using System;

public class Kitten : Cat, ISound
{
    public Kitten(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine(" meaows!Meaow!");
    }
}

