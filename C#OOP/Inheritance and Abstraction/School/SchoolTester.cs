using System;

public class SchoolTester
{
    static void Main()
    {
        Student pesho = new Student("Pesho", 14);

        Discipline mathematics = new Discipline("Mathematics", 12, null, pesho);
        Discipline history = new Discipline("History", 8, null, pesho);

        Teacher ivan = new Teacher("Ivan", "some details about Ivan", mathematics);
        Teacher kiro = new Teacher("Kiro", "some details about Kiro", history);

        SchoolClass thirdA = new SchoolClass("Third - A", null, ivan, kiro);
        
    }
}

