using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

class StudentTester
{
    private static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Milena", "Kirova", 17, 203313, "02 882228", "milena@abv.bg", 1, "aplha", 2, 4, 5, 3, 2));
        students.Add(new Student("Stefan", "Popov", 21, 203114, "087 882958", "stefan@mail.bg", 1, "aplha", 4, 4, 5, 3,
            3));
        students.Add(new Student("Asya", "Manova", 25, 203414, "087 882200", "asya@gmail.com", 2, "beta", 5, 4, 5, 5, 5));
        students.Add(new Student("Diana", "Petrova", 20, 203915, "+3592 112228", "d_petrova@mail.bg", 2, "beta", 5, 4, 5,
            6, 6));
        students.Add(new Student("Ivan", "Ivanov", 19, 203814, "087 822228", "iivanov@yahoo.com", 2, "beta", 2, 6, 2, 6,
            6));
        students.Add(new Student("Ivan", "Asenov", 19, 203512, "+359 2 881228", "iivanov@abv.bg", 1, "aplha", 6, 3, 3, 6,
            6));

        // Sort & print group2 students by FirstName
        var queryGroup2 =
            from student in students
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

        Console.WriteLine("Group 2 ordered by first name:");
        foreach (var student in queryGroup2)
        {
            Console.WriteLine(student);
        }

        // All students that their FirstName is alphabetically before their LastName
        var queryName =
            from student in students
            where String.Compare(student.FirstName, student.LastName) < 0
            select student;

        Console.WriteLine();
        Console.WriteLine("Students which their first name is alphabetically before their last name: ");
        foreach (var student in queryName)
        {
            Console.WriteLine(student);
        }

        // Students by Age only FirstName, LastName and Age
        var queryStudentsByAge =
            from student in students
            where (student.Age >= 18 && student.Age <= 24)
            orderby student.Age
            // not a part of the taks but..
            select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };

        Console.WriteLine();
        Console.WriteLine("Students by age:");
        foreach (var student in queryStudentsByAge)
        {
            Console.WriteLine("{0} {1} age: {2}", student.FirstName, student.LastName, student.Age);
        }

        // Students in descending order by FirstName and LastName with Lambda and LINQ
        //Lambda
        var studentsByNameDescending = students
            .OrderByDescending(s => s.FirstName)
            .ThenByDescending(s => s.LastName).Select(s => new { FirstName = s.FirstName, LastName = s.LastName });

        Console.WriteLine();
        Console.WriteLine("Students by descending first and last name:");
        foreach (var student in studentsByNameDescending)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        // LINQ
        // var queryStudentsByNameDescending =
        //     from student in students
        //     orderby student.FirstName descending, student.LastName descending
        //     select new {FirstName = student.FirstName, LastName = student.LastName};

        // Console.WriteLine();
        // Console.WriteLine("Students by descending first and last name:");
        // foreach (var student in queryStudentsByNameDescending)
        // {
        //     Console.WriteLine("{0} {1}",student.FirstName, student.LastName);
        // }

        // Students that have email @abv.bg
        var queryEmailAbv =
            from student in students
            where student.Email.EndsWith("@abv.bg")
            select student;

        Console.WriteLine();
        Console.WriteLine("Students with emails in abv.bg:");
        foreach (var student in queryEmailAbv)
        {
            Console.WriteLine(student);
        }

        // Students with phone in Sofia (02/ +3592/ +359 2)
        var queryPhoneInSofia =
            from student in students
            where
                (student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                 student.Phone.StartsWith("+359 2"))
            select student;

        Console.WriteLine();
        Console.WriteLine("Students with phone in Sofia:");
        foreach (var student in queryPhoneInSofia)
        {
            Console.WriteLine(student);
        }

        // Excellent students with at least 1 mark Excellent(6)
        var queryExcellentStudents =
            from student in students
            where student.Marks.Contains(6)
            select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

        Console.WriteLine();
        Console.WriteLine("Excellent students with at least 1 mark Excellent(6):");
        foreach (var student in queryExcellentStudents)
        {
            var currentMarks = Student.ConvertMarksFromListToString(student.Marks);
            Console.WriteLine(student.FullName + " marks: " + currentMarks);
        }

        // Weak students - students with exactly two marks "2"
        var weakStudents = students.FindAll(s => s.IsWeakStudent(s.Marks));

        Console.WriteLine();
        Console.WriteLine("Weak students (with exactly two marks - 2):");
        foreach (var student in weakStudents)
        {
            Console.WriteLine(student);
        }

        // Students enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber)
        var enrolledStudents = students
            .FindAll(s => s.FacultyNumber.ToString().EndsWith("14"))
            .Select(s => new { FullName = s.FirstName + " " + s.LastName, s.Marks });

        Console.WriteLine();
        Console.WriteLine("Students enrolled in 2014:");
        foreach (var student in enrolledStudents)
        {
            var currentMarks = Student.ConvertMarksFromListToString(student.Marks);
            Console.WriteLine(student.FullName + " marks: " + currentMarks);
        }

        // Students by group name
        var groupNames = new HashSet<string>();
        foreach (var student in students)
        {
            groupNames.Add(student.GroupName);
        }

        Console.WriteLine();
        Console.WriteLine("Students grouped by groupname:");
        foreach (var groupName in groupNames)
        {
            var groupStudents = students
                .FindAll(s => s.GroupName == groupName)
                .Select(s => s);

            foreach (var student in groupStudents)
            {
                Console.WriteLine(student);
            }
        }

        // Group names along with students
        var groupedByGroupName =
            from student
                in students
            group student by student.GroupName into g
            select new { GroupName = g.Key, students = g.ToList() };

        Console.WriteLine();
        Console.WriteLine("Students in groups: ");
        foreach (var item in groupedByGroupName)
        {
            Console.WriteLine(item.GroupName);
            Console.WriteLine("{0}", string.Join("\n", item.students));
        }

        var specialties = new List<StudentSpecialty>();
        specialties.Add(new StudentSpecialty("Web Developer", 203313));
        specialties.Add(new StudentSpecialty("PHP Developer", 203313));
        specialties.Add(new StudentSpecialty("Web Developer", 203114));
        specialties.Add(new StudentSpecialty("Web Developer", 203814));
        specialties.Add(new StudentSpecialty("PHP Developer", 203414));
        specialties.Add(new StudentSpecialty("PHP Developer", 203915));
        specialties.Add(new StudentSpecialty("QA Engineer", 203814));
        specialties.Add(new StudentSpecialty("Web Developer", 203512));

        // Join Student and Specialty via faculty number
        var queryStudentsAndSpecialties =
            from student in students
            join specalty in specialties
                on student.FacultyNumber equals specalty.FacultyNumber
            orderby student.FirstName, student.LastName
            select new
            {
                FullName = student.FirstName + " " + student.LastName,
                FacultyNum = student.FacultyNumber,
                Specialty = specalty.Name
            };

        Console.WriteLine();
        Console.WriteLine("Student, faculty number and specialty:");
        foreach (var item in queryStudentsAndSpecialties)
        {
            Console.WriteLine(item.FullName + " " + item.FacultyNum + " " + item.Specialty);
        }
    }
}