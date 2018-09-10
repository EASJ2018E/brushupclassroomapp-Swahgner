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

            Student stud1 = new Student("Nicolai Vagner", 18, 10);
            Student stud2 = new Student("Bastian Mødekjær", 02, 01);
            Student stud3 = new Student("Anders Jagd", 12, 04);

            class3b.AddStudentToClass(stud1);
            class3b.AddStudentToClass(stud2);
            class3b.AddStudentToClass(stud3);
        }
    }
}
