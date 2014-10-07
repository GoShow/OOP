using System;

class Developer : Employee
{
    private Project[] projects;
    public Developer(long id, string firstName, string lastName, decimal salary, Department department, params Project[] projects)
        : base(id, firstName, lastName, salary, department)
    {
        this.Projects = projects;
    }

    public Project[] Projects
    {
        get
        {
            return this.projects;
        }

        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Projects arrray can't be empty");
            }
            this.projects = value;
        }
    }

    public override string ToString()
    {
        string projectsString = "";
        foreach (var project in this.Projects)
        {
            projectsString += "\n" + project;
        }
        return "\nDeveloper: " + base.ToString() + "\nProjects: " + projectsString;
    }


}

