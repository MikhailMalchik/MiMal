using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    partial class Flowers : Goods

    {
        public virtual void GetClockInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost},Color: {Color},Size: {Size}");
        }
        public override string ToString()
        {
            return "Tostring Flowers";
        }
    }
}
