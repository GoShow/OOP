using System;
using System.Collections.Generic;
using System.Linq;
class ComputerTest
{
    static void Main()
    {
        List<Computer> computers = new List<Computer>();

        Computer dell = new Computer("Dell", "AMD 2.4 Ghz", 245.60m, "ATI Radeon", 600m, "ASRock", 320.50m, "Cool Hard Disk", 500);
        Computer acer = new Computer("Acer", "Intel 4.2 Ghz", 125.60m, "NVidia", 400m,"ASRock", 120.50m,"Not Cool Hard Disk", 300, null, null, "Details about motherboard");
        Computer hp = new Computer("HP", "Intel 4.2+ Ghz", 345.60m, "NVidia", 200m, "ASRock", 156.50m, "Best Hard Disk", 600, "Some processor details", "Some graphics details", "Some motherboard details", "Some hard disk details");

        computers.Add(dell);
        computers.Add(acer);
        computers.Add(hp);
        

        // with callback function doing the same
        //computers.Sort((comp1, comp2) => comp1.TotalPrice.CompareTo(comp2.TotalPrice));
 
        computers = computers.OrderBy(x => x.TotalPrice).ToList();
        
        foreach (var computer in computers)
        {
            computer.DisplayInfo();
            Console.WriteLine();
        }
    }
}

