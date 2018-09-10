using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public Student(string name, int birthMonth, int birhDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birhDay;
        }
    }
}
