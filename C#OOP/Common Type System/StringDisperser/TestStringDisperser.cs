namespace StringDisperser
{
    using System;

    class TestSpringDesperser
    {
        static void Main(string[] args)
        {
            StringDisperser gosho = new StringDisperser("Gosho", "Georgiev", "Georgievski");
            StringDisperser ivan = new StringDisperser("Gosho", "Georgiev", "Georgievski");
            Console.WriteLine("Are gosho and ivan equal: {0}", Equals(gosho, ivan));
            Console.WriteLine("Are gosho and pesho equal using '!=': {0}", (gosho != ivan));
            Console.WriteLine();

            var kolio = (StringDisperser) gosho.Clone();
            kolio.FirstName = "Kolio";
            kolio.MiddleName = "Kolev";
            kolio.LastName = "Kolistiya";
            Console.WriteLine("Original: {0}", gosho);
            Console.WriteLine("Clone: {0}", kolio);
            Console.WriteLine();

            ivan.FirstName = "Ivan";
            ivan.LastName = "Stefanov";

            StringDisperser[] stringDispersers = {kolio, ivan, gosho};
            Array.Sort(stringDispersers);
            Console.WriteLine("Sorted: ");
            foreach (var stringDisperser in stringDispersers)
            {
                Console.WriteLine(stringDisperser);
            }

            Console.WriteLine();
            Console.Write("foreach the Kolio: ");
            foreach (var ch in kolio)
            {
                Console.Write(ch +  " ");
            }
        }

        
    }
}
