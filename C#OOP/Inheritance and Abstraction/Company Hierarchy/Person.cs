using System;

public abstract class Person : IPerson
{
    private long id;
    private string firstName;
    private string lastName;

    public Person(long id, string firstName, string lastName)
    {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public long ID
    {
        get
        {
            return this.id;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("ID must be greater then zero");
            }
            this.id = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("First name can't be empty or null");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Last name can't be empty or null");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        return String.Format("{0} {1} ID: {2}", this.FirstName, this.LastName, this.ID);
    }
}

