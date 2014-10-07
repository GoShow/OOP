using System;

public class Manager : Person, IManager
{
    private Employee[] employees;
    public Manager(long id, string firstName, string lastName, params Employee[] employees)
        : base(id, firstName, lastName)
    {
        this.Employees = employees;
    }

    public Employee[] Employees
    {
        get
        {
            return this.employees;
        }

        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Employees array can't be empty");
            }

            this.employees = value;
        }
    }

    public override string ToString()
    {
        string employeesString = "";
        foreach (var employee in this.Employees)
        {
            employeesString += "\n" + employee;
        }
        return "Manager: " + base.ToString() + "\nEmployees under his command: " + employeesString;
    }
}

