using System;

public class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
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
            
            this.details = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.price = value;
        }
    }

    private static bool IsValidString(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return false;
        }
        return true;
    }
    public override string ToString()
    {
        string componentStr = String.Format("{0}, price: {1} lv", this.Name, this.Price);
        if (!String.IsNullOrEmpty(this.Details))
        {
            componentStr += ", details: " + this.Details;
        }
        return componentStr;
    }
}

