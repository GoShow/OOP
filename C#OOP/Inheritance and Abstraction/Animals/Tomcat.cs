using System;

class Tomcat : Cat, ISound
{
    public Tomcat(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine(" is MEAAAAAAAAOOOOOOOOOOOOWWWWWWWWWWWIIIIIIIIING!");
    }
}

