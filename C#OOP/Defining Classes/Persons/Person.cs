using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(String name, int age)
        : this(name, age, null)
    {
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Length > 100)
            {
                throw new ArgumentOutOfRangeException("The name should be in range [1..100] symbols!");
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
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age should be in range [1..100]");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if ((value == null) || (value.Length > 0 && value.Contains("@") && value.Length < 101))
            {
                
                this.email = value;
            }

            else
            {
                if (value.Length > 100)
                {
                    throw new Exception("Email should be less than 100 symbols");
                }
                throw new ArgumentException("Email", "Invalid email");
            }

        }
    }

    public override string ToString()
    {
        string emailStr = "";
        if (this.Email != null)
        {
            emailStr = "\nEmail: " + this.Email;
        }
        return String.Format("Name: {0}\nAge: {1}{2}", this.Name, this.Age, emailStr);
    }
}

