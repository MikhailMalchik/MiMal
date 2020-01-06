using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    public class Clock : Goods
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public Clock(string Type, string Name, int Cost, int Size)
        {
            this.Type = Type;
            this.Name = Name;
            this.Cost = Cost;
            this.Size = Size;
        }
        public virtual void GetClockInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost},Size: {Size}");
        }
        public override string ToString()
        {
            return "Tostring clock";
        }


    }
}
