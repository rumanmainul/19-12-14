using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            Student aStudent1 = new Student();
            aStudent1.firstName = "Salam";
            aStudent1.lastName = "Mahmud";
            aStudent1.regNumber = "1234";

            Student aStudent2 = new Student();
            aStudent2.firstName = "Alim";
            aStudent2.lastName = "Islam";
            aStudent2.regNumber = "1235";

            Student aStudent3 = new Student();
            aStudent3.firstName = "Karim";
            aStudent3.lastName = "Khan";
            aStudent3.regNumber = "1236";

            students[0] = aStudent1;
            students[1] = aStudent2;
            students[2] = aStudent3;

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetFullName()+" Reg: -> "+student.regNumber);
            }
            Console.ReadKey();
        }
    }
}
