using System;
using System.Collections.Generic;

class SalesEmployee : Employee
{
    private Sale[] sales;

    public SalesEmployee(long id, string firstName, string lastName, decimal salary, Department department, params Sale[] sales)
        : base(id, firstName, lastName, salary, department)
    {
        this.Sales = sales;
    }

    public Sale[] Sales
    {
        get
        {
            return sales;
        }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Sales array can't be empty");
            }

            sales = value;
        }
    }

    public override string ToString()
    {
        string salesString = "";
        foreach (var sale in this.Sales)
        {
            salesString += "\n" + sale;
        }

        return "\nSales Employee: " + base.ToString() + "\nSales: " + salesString;
    }
}

