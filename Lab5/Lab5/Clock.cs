using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Clock : Goods
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
        public Clock(string Type, string Name, int Cost)
        {
            this.Type = Type;
            this.Name = Name;
            this.Cost = Cost;
        }
        public virtual void GetClockInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost}");
        }
        public override string ToString()
        {
            return "Tostring clock";
        }

    }
}
