using System;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string graphicsCard;
    private string screenSize;
    private Battery battery;
    private decimal price;



    public Laptop(string model, string manufacturer, string processor, string graphicsCard, string type, double lifeInHours, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.GraphicsCard = graphicsCard;
        this.battery = new Battery(type, lifeInHours);
        this.Price = price;
    }

    public Laptop(string model, string manufacturer, string processor, string graphicsCard, string type)
        : this(model, manufacturer, processor, graphicsCard, type, 0, 0)
    {
    }
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
            }
            this.model = value;
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
            }
            this.manufacturer = value;

        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
            }
            this.processor = value;
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
            }
            this.graphicsCard = value;
        }
    }
    public string ScreenSize
    {
        get
        {
            return this.screenSize;
        }
        set
        {
            if (!IsValidString(value))
            {
                throw new ArgumentNullException();
            }
            this.screenSize = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
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


    private bool IsValidString(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        string result = "";
        if (this.Price != 0)
        {
            //check if Price is 0 don't print it
            result = String.Format(", Price: {0}", this.Price);
        }
        return String.Format("Model: {0}\nManufacturer: {1}\nProcessor: {2}\nGraphics card: {3}\nBattery: {4}{5}",
            this.Model, this.Manufacturer, this.Processor, this.GraphicsCard, this.Battery, result);
    }
}

