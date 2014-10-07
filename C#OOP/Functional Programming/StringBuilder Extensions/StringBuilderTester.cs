using System;
using System.Collections.Generic;
using System.Text;

class StringBuilderTester
{
    static void Main()
    {
        var originalString = new StringBuilder("this is a very very very long string :)");

        Console.WriteLine("Original string: {0}", originalString);

        // New extension method Substring is added to StringBuilder Class
        string substring = originalString.Substring(10, 4).ToString();
        Console.WriteLine(substring);

        // New extension method RemoveText is added to StringBuilder Class
        originalString.RemoveText("very");
        Console.WriteLine(originalString);

        // New extension method AppendAll<T> is added to StringBuilder Class
        var numbers = new List<double>{2.34, 3.456, 0.2345};
        var words = new List<string>{"abra", "kadabra"};

        originalString.AppendAll(numbers);
        originalString.AppendAll(words);

        Console.WriteLine(originalString);
    }
}

