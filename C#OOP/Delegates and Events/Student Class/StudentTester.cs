using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    class StudentTester
    {
        static void Main()
        {
            var student = new Student("Pesho", 16);
            student.Name = "Gosho";
            student.Age = 32;
        }
    }
}
