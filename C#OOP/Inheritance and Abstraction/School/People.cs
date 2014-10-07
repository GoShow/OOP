using System;

public abstract class People : INameable
{
    private string name;

    protected People(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be null or empty");
            }

            this.name = value;
        }
    }
}



