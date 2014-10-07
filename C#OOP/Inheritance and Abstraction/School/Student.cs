using System;

public class Student : People
{
    private int classNumber;

    public Student(string name, int classNumber, string details = null) : base(name)
    {
        this.ClassNumber = classNumber;
        this.Details = details;
    }

    public int ClassNumber
    {
        get
        {
            return classNumber;
        }

        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Class number can't be zero or less");
            }

            this.classNumber = value;
        }
    }

    public string Details { get; set; }
}

