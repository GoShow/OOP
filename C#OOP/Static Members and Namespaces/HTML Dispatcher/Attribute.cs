using System;

class Attribute
{
    private string attrName;
    private string attrValue;
    public Attribute(string attrName, string attrValue)
    {
        this.AttrName = attrName;
        this.AttrValue = attrValue;
    }

    public string AttrName
    {
        get
        {
            return this.attrName;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
            this.attrName = value;
        }
    }

    public string AttrValue
    {
        get
        {
            return this.attrValue;    
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }

            this.attrValue = value;
        }
    }

    public override string ToString()
    {
        return " " + this.AttrName + "=\"" + this.AttrValue + "\"";
    }
}

