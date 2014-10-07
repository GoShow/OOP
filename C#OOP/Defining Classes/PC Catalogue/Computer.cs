using System;
using System.Reflection;

class Computer
{
    private string name;
    private Component processor;
    private Component graphicsCard;
    private Component motherboard;
    private Component hardDisk;

    public Computer(
        string computerName, string processorName, decimal processorPrice,
        string graphicsCardName, decimal graphicsCardPrice, string motherboardName,
        decimal motherboardPrice, string hardDiskName, decimal hardDiskPrice,
        string processorDetails = null, string graphicsCardDetails = null,
        string motherboardDetails = null, string hardDiskDetails = null)
    {
        this.Name = computerName;
        this.processor = new Component(processorName, processorPrice, processorDetails);
        this.graphicsCard = new Component(graphicsCardName, graphicsCardPrice, graphicsCardDetails);
        this.motherboard = new Component(motherboardName, motherboardPrice, motherboardDetails);
        this.hardDisk = new Component(hardDiskName, hardDiskPrice, hardDiskDetails);
        this.Processor = processor;
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

    public Component Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }
    public Component GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }

    public Component Motherboard
    {
        get
        {
            return this.motherboard;
        }
        set
        {
            this.motherboard = value;
        }
    }

    public Component HardDisk
    {
        get
        {
            return this.hardDisk;
        }
        set
        {
            this.hardDisk = value;
        }
    }

    public decimal TotalPrice
    {
        get
        {      
            return this.Processor.Price + this.GraphicsCard.Price + this.Motherboard.Price + this.HardDisk.Price;
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

    public void DisplayInfo()
    {

        Console.WriteLine(String.Format("Computer: {0}\nProcessor: {1}\nGraphics card: {2}\nMotherboard: {3}\nHDD: {4}\nTotal price: {5} lv",
            this.Name, this.Processor, this.GraphicsCard, this.Motherboard, this.HardDisk, this.TotalPrice));
    }


}

