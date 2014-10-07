using System;

public abstract class Employee : Person, IEmployee
{
    private decimal salary;
    private Department department;
    protected Employee(long id, string firstName, string lastName, decimal salary, Department department)
        : base(id, firstName, lastName)
    {
        this.salary = salary;
        this.department = department;
    }

    public decimal Salary
    {
        get
        {
            return this.salary;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary can't be zero or less");
            }

            this.salary = value;
        }
    }

    public Department Department
    {
        get
        {
            return this.department;
        }
        set
        {
            this.department = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + String.Format("\ndepartment: {0}\nsalary: {1}lv", this.Department, this.Salary);
    }
}

