using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var words = new List<string>{"fuck", "suck", "lick", "eye", "dick", "porn", "porhub" };

        // New extension method WhereNot is added to LINQ
        var whereNotCollection = string.Join(", ",words.WhereNot(w => w == "eye"));
        Console.WriteLine(whereNotCollection);

        // New extension method Repeat is added to LINQ
        var repeatCollection = string.Join(", ", words.Repeat(2));
        Console.WriteLine(repeatCollection);

        // New extension method WhereEndsWith is added to LINQ
        var suffixes = new List<string>() { "ick", "hub" };
        var endsWithCollection = string.Join(", ", words.WhereEndsWith(suffixes));
        Console.WriteLine(endsWithCollection);
    }
}
