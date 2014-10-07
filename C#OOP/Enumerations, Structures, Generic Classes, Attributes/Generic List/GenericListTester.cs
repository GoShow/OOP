using System;
using System.Collections.Generic;

class GenericListTester
{
    static void Main()
    {
        GenericList<int> genList = new GenericList<int>();
        GenericList<string> stringGenericList = new GenericList<string>();
        
        // version attibute display
        var customAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), true);

        Console.WriteLine("This GenericList<T> class's version is {0}", customAttributes[0]);
        Console.WriteLine();

        genList.Add(5);
        genList.Add(15);
        genList.Add(52);
        genList.Add(152);
        genList.Add(522);

        genList.InsertAt(0, -120);
        genList.InsertAt(3, 4222220);

        Console.WriteLine(genList);

        genList.RemoveAt(0);
        genList.RemoveAt(2);

        // uncomment to try the Clear() method;
        // genList.Clear();

        Console.WriteLine(genList);

        int searchedElement = 5442;
        int searchedIndex = genList.Find(searchedElement);

        if (searchedIndex > -1)
        {
            Console.WriteLine("Index of {0} is {1}", searchedElement, searchedIndex);
        }
        else
        {
            Console.WriteLine("No such element {0} in list", searchedElement);
        }

    }
}

