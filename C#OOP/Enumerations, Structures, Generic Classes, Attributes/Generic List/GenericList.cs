using System;
using System.Collections.Generic;

[Version(2, 75)]
public class GenericList<T>
{

    const int DefaultCapacity = 16;

    private T[] elements;
    private int count = 0;

    public GenericList(int capacity = DefaultCapacity)
    {
        elements = new T[capacity];
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            return elements[index];
        }
    }
    public void Add(T element)
    {
        if (count == elements.Length)
        {
            this.elements = AutoGrow();
        }

        this.elements[count] = element;
        count++;
    }

    public void InsertAt(int index, T element)
    {
        if (index < 0 || index > count - 1)
        {
            throw new IndexOutOfRangeException("Index should be inside the bounds of the list");
        }

        T[] temp = new T[this.elements.Length + 1];

        for (int i = 0; i < index; i++)
        {
            temp[i] = this.elements[i];
        }

        temp[index] = element;

        for (int i = index; i < this.elements.Length; i++)
        {
            temp[i + 1] = this.elements[i];
        }

        this.elements = temp;
        this.count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > count - 1)
        {
            throw new IndexOutOfRangeException("Index should be inside the bounds of the list");
        }

        T[] temp = new T[this.elements.Length];

        for (int i = 0; i < index; i++)
        {
            temp[i] = this.elements[i];
        }

        for (int i = index + 1; i < this.elements.Length; i++)
        {
            temp[i - 1] = this.elements[i];
        }

        this.elements = temp;
        count--;
    }

    public void Clear()
    {
        T[] temp = new T[this.elements.Length];
        this.elements = temp;
        count = 0;
    }

    public int Find(T element)
    {
        for (int i = 0; i < this.elements.Length; i++)
        {
            if (element.Equals(this.elements[i]))
            {
                return i;
            }
        }

        return -1;
    }

    public override string ToString()
    {
        string listStr = "";

        for (int i = 0; i < count; i++)
        {
            listStr += this.elements[i] + "\n";
        }

        return listStr;
    }

    private T[] AutoGrow() 
    {
        T[] resized = new T[this.elements.Length * 2];

        for (int i = 0; i < this.elements.Length; i++)
        {
            resized[i] = this.elements[i];
        }
        return resized;
    }
}

