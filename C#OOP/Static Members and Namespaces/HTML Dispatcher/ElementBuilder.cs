using System;
using System.Collections.Generic;

class ElementBuilder
{
    private string name;
    private IList<Attribute> attributes = new List<Attribute>();
    private string content;
    public ElementBuilder(string name)
    {
        this.Name = name;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }

            this.name = value;
        }
    }

    public IList<Attribute> Attributes
    {
        get
        {
            return this.attributes;
        }
        set
        {
            this.attributes = value;
        }
    }

    public string Content
    {
        get
        {
            return this.content;
        }
        private set
        {
        }
    }
    public void AddAttribute(string attrName, string attrValue)
    {
        Attribute nextAttribute = new Attribute(attrName, attrValue);
        this.attributes.Add(nextAttribute);
    }

    public void AddContent (string str)
    {
        this.content = str;
    }

    public override string ToString()
    {
        string attrString = "<" + this.Name;

        foreach (var attribute in Attributes)
        {
            attrString += attribute;
        }

        attrString += ">" + this.Content + "</" + this.Name + ">";

        return attrString;
    }

    public static string operator *(ElementBuilder a, int num)
    {
        string str = "";
        for (int i = 0; i < num; i++)
        {
            str += a;   
        }
        
        return str;
    }
}

