using System;

class GalacticGPSTester
{
    static void Main()
    {
        Location home = new Location(0.234435, 25.234232, Planet.Earth);
        Location sofia = new Location(2, 123.45345435, Planet.Mercury);

        Console.WriteLine("Home is at {0}", home);
        Console.WriteLine("Sofia is at {0}", sofia);
    }
}

