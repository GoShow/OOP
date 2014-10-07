using System;

public class SchoolClass
{
    private Teacher[] teachers;
    private string uniqueTextIndetifier;

    public SchoolClass(string uniqueTextIndetifier, string details = null, params Teacher[] teachers)
    {
        this.UniqueTextIndetifier = uniqueTextIndetifier;
        this.Teachers = teachers;
        this.Details = details;
    }

    public Teacher[] Teachers
    {
        get
        {
            return this.teachers;
        }

        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Teachers array can't be empty");
            }

            this.teachers = value;
        }
    }

    public string UniqueTextIndetifier
    {
        get
        {
            return this.uniqueTextIndetifier;
        }

        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Unique text indetifier can't be empty");
            }

            this.uniqueTextIndetifier = value;
        }
    }

    public string Details { get; set; }
}
