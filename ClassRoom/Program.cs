using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom class3b = new ClassRoom("3B", DateTime.Parse("4-9-2018"));

            Student stud1 = new Student("Nicolai Vagner", 10, 18);
            Student stud2 = new Student("Bastian Mødekjær", 02, 01);
            Student stud3 = new Student("Anders Jagd", 12, 04);
            Student stud4 = new Student("John Knudsen", 65, 04);
            Student stud5 = new Student("Hans Jørgensen", -51, 04);

            class3b.AddStudentToClass(stud1);
            class3b.AddStudentToClass(stud2);
            class3b.AddStudentToClass(stud3);
            class3b.AddStudentToClass(stud4);
            class3b.AddStudentToClass(stud5);

            class3b.PrintAllInfo();

            class3b.CountSeasonBirthdays();

            Console.WriteLine("\n\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
