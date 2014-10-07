using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

class AnimalsTester
{
    static void Main()
    {
        Dog[] dogs =
        {
            new Dog("Sharo", 13, "male"),
            new Dog("kudjo", 9, "male"),
            new Dog("Milka", 6, "female"),
        };

        Frog[] frogs =
        {
            new Frog("Gudi", 11, "hermaphrodite"),
            new Frog("Sasha", 9, "female")
        };

        Tomcat[] tomcats =
        {
            new Tomcat("Jijo", 3, "not sure"),
            new Tomcat("Nedko", 6, "male for sure!")
        };

        Kitten[] kittens =
        {
            new Kitten("Dreben", 1, "male"),
            new Kitten("Golqmata", 2, "female")
        };

        List<Animal> allAnimals = new List<Animal>();
        allAnimals.AddRange(dogs);
        allAnimals.AddRange(frogs);
        allAnimals.AddRange(tomcats);
        allAnimals.AddRange(kittens);

        // Trying to make the dogs bark to see if method is working
        var dogsMakeNoise = dogs.OrderBy(d => d.Name);

        Console.WriteLine("Dogs make noise!");
        foreach (var dog in dogsMakeNoise)
        {
            Console.Write(dog.Name);
            dog.ProduceSound();
        }
        Console.WriteLine();

        // Get only dogs from allAnimals and print average age
        var dogsAge = allAnimals
            .Where(d => d.GetType() == typeof(Dog))
            .Select(d => d.Age);

        double dogsAverageAge = dogsAge.Average();
        Console.WriteLine("Average age of dogs is " + dogsAverageAge + " years.");

        // Get only frogs from allAnimals and print average age
        var frogsAge = allAnimals
            .Where(d => d.GetType() == typeof(Frog))
            .Select(d => d.Age);

        double frogsAverageAge = frogsAge.Average();
        Console.WriteLine("Average age of frogs is " + frogsAverageAge + " years.");

        // Get only tomcats from allAnimals and print average age
        var tomcatsAge = allAnimals
            .Where(d => d.GetType() == typeof(Tomcat))
            .Select(d => d.Age);

        double tomcatsAverageAge = tomcatsAge.Average();
        Console.WriteLine("Average age of tomcats is " + tomcatsAverageAge + " years.");

        // Get only kittens from allAnimals and print average age
        var kittensAge = allAnimals
            .Where(d => d.GetType() == typeof(Kitten))
            .Select(d => d.Age);

        double kittensAverageAge = kittensAge.Average();
        Console.WriteLine("Average age of kittens is " + kittensAverageAge + " years.");
    }
}

