using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private int facultyNumber;
    private string phone;
    private string email;
    private List<int> marks;
    private int groupNumber;
    private string groupName;

    public Student(string firstName, string lastname, int age, int facultyNumber,
        string phone, string email, int groupNumber, string groupName, params int[] marks)
    {
        this.FirstName = firstName;
        this.LastName = lastname;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.GroupNumber = groupNumber;
        this.GroupName = groupName;
        this.Marks = marks.ToList();
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("{0} can't be empty", this.firstName);
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
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Last name can't be empty");
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
            if (value <= 0)
            {
                throw new ArgumentException("Age can't be negative or zero");
            }

            this.age = value;
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

    public string Phone
    {
        get
        {
            return this.phone;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Phone can't be null or empty");
            }

            this.phone = value;
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
            if (String.IsNullOrEmpty(value) || !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email");
            }

            this.email = value;
        }
    }

    public List<int> Marks
    {
        get
        {
            return this.marks;
        }
        set
        {
            foreach (var i in value)
            {
                if (i < 2 || i > 6)
                {
                    throw new ArgumentException("Marks should be between 2 and 6");
                }
            }

            this.marks = value;
        }
    }

    public int GroupNumber
    {
        get
        {
            return this.groupNumber;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Group number can't be negative or zero");
            }

            this.groupNumber = value;
        }
    }

    public string GroupName
    {
        get
        {
            return this.groupName;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Group name can't be empty or null");
            }

            this.groupName = value;
        }
    }

    public static string ConvertMarksFromListToString(IList<int> marks)
    {
        return string.Join(", ", marks.Select(x => x.ToString()).ToArray());
    }

    public bool IsWeakStudent(List<int> numbers)
    {
        const int searchedMark = 2;
        const int numberOfSearchedMarks = 2;
        int searchedMarksCounter = 0;
        foreach (var number in numbers)
        {
            if (number == searchedMark)
            {
                searchedMarksCounter++;
            }
        }

        if (searchedMarksCounter == numberOfSearchedMarks)
        {
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        var marksString = string.Join(", ", this.Marks.ToArray());

        return String.Format("{0} {1} age: {2}, faculty number: {3}, group: {4}, group name: {5},\nphone number: {6}, email: {7}\nmarks: {8}",
            this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.GroupNumber, this.GroupName, this.Phone, this.Email, marksString);
    }
}

