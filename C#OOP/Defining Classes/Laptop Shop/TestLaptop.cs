using System;


namespace _01.Laptop_Shop
{
    class TestLaptop
    {
        static void Main()
        {
            Laptop dell = new Laptop("Dell-3251", "Dell", "Intel dual-core", "ATI Radeon 3242", "LiIon");
            Laptop sony = new Laptop("Sony-Vayo", "Sony", "Intel dual-core", "NVidia", "NiMh", 6.2, 234.55m);

            Console.WriteLine(sony);
            Console.WriteLine();
            Console.WriteLine(dell);
        }
    }
}
