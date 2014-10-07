using System;

public abstract class Animal : ISound
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be empty or null");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 1)
            {
                throw new ArgumentException("The age can't be zero or less");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Gender can't be empty or null");
            }

            this.gender = value;
        }
    }

    public abstract void ProduceSound();
}

