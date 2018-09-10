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
        public string BirthSeason { get; set; }

        public Student(string name, int birthMonth, int birhDay)
        {
            Name = name;
            if (birthMonth > 12 || birthMonth < 1)
            {
                Console.WriteLine($" ## You entered an invalid birthmonth for {name} - Changed to default (1) ## ");
                birthMonth = 1;
            }
            BirthMonth = birthMonth;
            BirthDay = birhDay;
            BirthSeason = GetBirthSeason();
        }

        private string GetBirthSeason()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
                return "Winter";
            else if (BirthMonth >= 3 && BirthMonth <= 5)
                return "Spring";
            else if (BirthMonth >= 6 && BirthMonth <= 8)
                return "Summer";
            else if (BirthMonth >= 9 && BirthMonth <= 11)
                return "Autumn";
            else
                return "The sudent's birthmonth is out of bounds!";
        }

        public override string ToString()
        {
            return " - Name: " + Name + " - Birthday: " + BirthDay + "/" + BirthMonth + " - Birthseason: " + BirthSeason;
        }
    }
}
