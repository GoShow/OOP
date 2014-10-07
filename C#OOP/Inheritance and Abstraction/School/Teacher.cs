using System;

public class Teacher : People
{


    private Discipline[] disciplines;

    public Teacher(string name, string details, params Discipline[] disciplines)
        : base(name)
    {
        this.Disciplines = disciplines;
        this.Details = details;
    }

    public Discipline[] Disciplines
    {
        get
        {
            return this.disciplines;
        }

        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Discplines array can't be empty");
            }
            
            this.disciplines = value;
        }
    }

    public string Details { get; set; }
}

