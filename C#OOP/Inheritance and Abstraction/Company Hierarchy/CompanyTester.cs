using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

class CompanyTester
{
    static void Main(string[] args)
    {
        Sale computer = new Sale("Dell","12-12-2014", 550);
        Sale dvd = new Sale("Philips", "12-12-2014", 400);
        Sale tv = new Sale("LG", "12-12-2014", 600);
        SalesEmployee george = new SalesEmployee(8120402363, "George", "Washington", 1500, Department.Production, dvd);
        SalesEmployee pesho = new SalesEmployee(84254041261, "Peter", "Cetera", 5200, Department.Sales, computer, tv);

        Project web = new Project("haus.bg", "04-04-1982", "some details");
        Project ludnica = new Project("ludnica.bg", "05-05-1945", "some details");
        ludnica.CloseProject();
        Developer gonzo = new Developer(84254041261, "Hristo", "Stoichkov", 41500, Department.Production, web, ludnica);

        Manager kiro = new Manager(6612129080, "Kiro", "Kirov-Kiristiq",george, pesho, gonzo);

        var listOfPeople = new List<IPerson>();
        listOfPeople.Add(kiro);
        listOfPeople.Add(gonzo);
        listOfPeople.Add(pesho);
        listOfPeople.Add(george);

        foreach (var person in listOfPeople)
        {
            Console.WriteLine(person);
            Console.WriteLine("--------------------------------------------------------------------------------");   
        }

    }
}
