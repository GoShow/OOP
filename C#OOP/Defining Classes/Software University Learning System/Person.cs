using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (!Validator.IsValidString(value))
            {
                throw new NullReferenceException("");
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
        set{
            if (!Validator.IsValidString(value))
            {
                throw new NullReferenceException("");
            }

            this.lastName = value;
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
            if (!Validator.IsValidAge(value))
            {
                throw new ArgumentOutOfRangeException();
            }

            this.age = value;
        }
    }
}

