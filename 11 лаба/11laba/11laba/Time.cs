using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    class Time : IComparable<Time>
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;

        }
        public int CompareTo(Time p)
        {
            return this.Hour.CompareTo(p.Hour);
        }
    }
}
