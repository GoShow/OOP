using System;

public abstract class Cat : Animal, ISound
{
    protected Cat(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

}

