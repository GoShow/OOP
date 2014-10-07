using System;

public class Student : Human
{
    private int facultyNumber;
    public Student(string firstName, string lastName, int facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if ((value.ToString().Length < 5 || value.ToString().Length > 10) || value < 0)
            {
                throw new ArgumentException("Invalid faculty number");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return String.Format("{0} {1} faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
    }
}

