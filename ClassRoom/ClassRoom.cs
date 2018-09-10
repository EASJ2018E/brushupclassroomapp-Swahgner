using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        private List<Student> classList = new List<Student>();
        private int _winterBirthdays = 0;
        private int _springBirthdays = 0;
        private int _summerBirthdays = 0;
        private int _autumnBirthdays = 0;


        public string ClassName { get; set; }
        public List<Student> ClassList { get { return classList; } set { classList = value; } }
        public DateTime TermStart { get; set; }
        
        public ClassRoom(string className, DateTime termStart)
        {
            ClassName = className;
            TermStart = termStart;
        }

        public void AddStudentToClass(Student student)
        {
            ClassList.Add(student);
        }

        public void CountSeasonBirthdays()
        {
            foreach (var student in ClassList)
            {
                switch (student.BirthSeason)
                {
                    case "Winter":
                        _winterBirthdays++;
                        break;
                    case "Spring":
                        _springBirthdays++;
                        break;
                    case "Summer":
                        _summerBirthdays++;
                        break;
                    case "Autumn":
                        _autumnBirthdays++;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Students from {ClassName} born in the winter: " + _winterBirthdays);
            Console.WriteLine($"Students from {ClassName} born in the spring: " + _springBirthdays);
            Console.WriteLine($"Students from {ClassName} born in the summer: " + _summerBirthdays);
            Console.WriteLine($"Students from {ClassName} born in the autumn: " + _autumnBirthdays);
        }

        public void PrintAllInfo()
        {
            Console.WriteLine("Classname: " + ClassName + " - Termstart: " + TermStart.Day + "/" + TermStart.Month + "-" + TermStart.Year);
            foreach (var student in ClassList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
