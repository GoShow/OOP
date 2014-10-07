using System;

class TestPerson
{
    static void Main()
    {

        Person pesho = new Person("Pesho", 25, "ivan@gmail.com");
        Person goshow = new Person("GoShow", 32);
        Console.WriteLine(pesho);
        Console.WriteLine();
        Console.WriteLine(goshow);
    }
}
