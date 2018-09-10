using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
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
    }
}
