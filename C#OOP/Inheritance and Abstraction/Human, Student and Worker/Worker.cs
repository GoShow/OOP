using System;

public class Worker : Human
{
    private const int weekWorkDays = 5;
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException("Salary can't be zero or less");
            }

            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException("Work hours can't be zero or less");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour()
    {
        return Math.Round(this.WeekSalary / (workHoursPerDay * weekWorkDays), 2);
    }

    public override string ToString()
    {
        return String.Format("{0} {1} work hours per day: {2}, week salary: {3}", this.FirstName, this.LastName, this.WorkHoursPerDay, this.WeekSalary);
    }
}

