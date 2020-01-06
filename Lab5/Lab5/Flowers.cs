using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Flowers : Goods
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public Flowers(string Type, string Name, int Cost, string Color)
        {
            this.Type = Type;
            this.Name = Name;
            this.Cost = Cost;
            this.Color = Color;
        }
        public virtual void GetClockInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost},Color: {Color}");
        }
        public override string ToString()
        {
            return  "Tostring Flowers";
        }
    }
}
