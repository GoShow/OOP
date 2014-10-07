using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        var students = new List<Student>()
        {
            new Student("Ivan", "Ivanov", 223442),
            new Student("Petar", "Ivanov", 213442),
            new Student("Stefan", "Ivanov", 123442),
            new Student("Zlatan", "Georgiev", 623442),
            new Student("Ivan", "Stefanov", 523442),
            new Student("Ginka", "Ivanova", 522442),
            new Student("Ivanka", "Stefanova", 923442),
            new Student("Kichka", "Bodurova", 723432),
            new Student("Kosmadinka", "Dokolenkova", 223542),
            new Student("Aman", "Amanov", 223842)
        };

        // Students sort by faculty number
        var sortedStudentsFacultyNumber = students.OrderBy(s => s.FacultyNumber);

        Console.WriteLine("Students ordered by faculty number:");
        foreach (var student in sortedStudentsFacultyNumber)
        {
            Console.WriteLine("{0} {1} {2}", student.FacultyNumber,student.FirstName,student.LastName);
        }

        var workers = new List<Worker>()
        {       
            new Worker("Peter", "Petrov", 240, 23),
            new Worker("Stamat", "Stamatov", 2134, 42),
            new Worker("Stefan", "Ivanov", 123, 42),
            new Worker("Zlatan", "Zlatanov", 6234, 42),
            new Worker("Ivan", "Stefanov", 523, 40),
            new Worker("Ginka", "Ginkova", 522, 32),
            new Worker("Kuchka", "Kuchkova", 923, 62),
            new Worker("Kich", "Bodurov", 7234, 32),
            new Worker("Kosmadin", "Dokolenkov", 2235, 12),
            new Worker("Amanka", "Amanova", 2238, 42)
        };      
                
        // Workers sort by payment per hour
        var sortedWorkersPaymentPerHour = workers.OrderByDescending(w => w.MoneyPerHour());

        Console.WriteLine();
        Console.WriteLine("Workers ordered descending money per hour:");
        foreach (var worker in sortedWorkersPaymentPerHour)
        {
            Console.WriteLine("{0} {1} {2}", worker.MoneyPerHour(), worker.FirstName, worker.LastName);
        }

        // All humans sort by first and last name
        var studentsAndWorkers = new List<Human>();
        studentsAndWorkers.AddRange(students);
        studentsAndWorkers.AddRange(workers);
        
        Console.WriteLine();
        Console.WriteLine("All human's list ordered by name:");

        var sortedStudentsAndWorkers = studentsAndWorkers
            .OrderBy(s => s.FirstName)
            .ThenBy(s => s.LastName);
        
        foreach (var human in sortedStudentsAndWorkers)
        {
            Console.WriteLine(human);
        }
    }
}

