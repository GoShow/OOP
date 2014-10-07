using System;

public class Battery
{
    private string type;
    private double lifeInHours;

    public Battery(string type, double lifeInHours)
    {
        this.Type = type;
        this.LifeInHours = lifeInHours;
    }
    public string Type
    {
        get
        {
            return this.type;
        }
        set
        {
            if (String.IsNullOrEmpty(value)){
                throw new ArgumentNullException();
            }
            this.type = value;
        }
    }
    
    public double LifeInHours
    {
        get
        {
            return this.lifeInHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.lifeInHours = value;
        }
    }

    public override string ToString()
    {
        string result = "";
        if (this.lifeInHours != 0)
        {
            //check if lifeInHours is 0 don't print it
            result = String.Format(", life in hours: {0}", this.LifeInHours);
        }
        return String.Format("[type: {0}{1}]", this.Type, result);
    }
    
}

