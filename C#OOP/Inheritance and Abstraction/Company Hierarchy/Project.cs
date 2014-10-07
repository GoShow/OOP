using System;

public class Project
{
    private string name;
    private string startDate;
    private string details;
    private string state = "open";

    public Project(string name, string startDate, string details)
    {
        this.name = name;
        this.startDate = startDate;
        this.details = details;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be empty or null");
            }

            this.name = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Details can't be empty or null");
            }

            details = value;
        }
    }

    public string StartDate
    {
        get
        {
            return startDate;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Date can't be empty or null");
            }

            startDate = value;
        }
    }

    public string State
    {
        get
        {
            return this.state;
        }
    }

    public void CloseProject()
    {
        this.state = "closed";
    }

    public override string ToString()
    {
        return String.Format("project: {0}, start date: {1}, details: {2}, the project is {3}.", this.Name,
            this.StartDate, this.Details, this.State);
    }
}

