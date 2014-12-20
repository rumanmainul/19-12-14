using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
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

            students.Add(aStudent1);
            students.Add(aStudent2);
            students.Add(aStudent3);

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.GetFullName());
            }
            Console.ReadKey();
        }
    }
}
