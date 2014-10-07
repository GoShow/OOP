using System;

public class StudentSpecialty
{
    private string name;
    private int facultyNumber;

    public StudentSpecialty(string name, int facultyNumber)
    {
        this.Name = name;
        this.FacultyNumber = facultyNumber;
    }

    public string Name {
        get 
        {
            return this.name;         
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Specialty name can't be empty");
            }

            this.name = value;
        } 
    }
    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value <= 0 || value.ToString().Length != 6)
            {
                throw new ArgumentException("Invalid faculty number");
            }

            this.facultyNumber = value;
        }
    }

}

