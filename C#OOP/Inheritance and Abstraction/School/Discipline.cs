using System;

public class Discipline : INameable
{
    private string name;
    private int numberOfLectures;
    private Student[] students;

    public Discipline(string name, int numberOfLectures,string details = null, params Student[] students)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.Students = students;
        this.Details = details;
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
                throw new ArgumentException("Name can't be empty or null");
            }
        }
    }

    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }

        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("Number of lectures can't be zero or less");
            }
            this.numberOfLectures = value;
        }
    }

    public Student[] Students
    {
        get
        {
            return this.students;
        }

        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Students array can't be empty");
            }

           this.students = value;
        }
    }

    public string Details { get; set; }
}

