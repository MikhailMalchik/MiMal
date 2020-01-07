using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    public class Teacher
    {
        public string NameT { get; set; }
        public string Class { get; set; }
        public Teacher(string name, string cls)
        {
            this.NameT = name;
            this.Class = cls;
        }
    }
}
