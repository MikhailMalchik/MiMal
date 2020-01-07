using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public Student(string name, string cls)
        {
            this.Name = name;
            this.Class = cls;
        }
    }
}
