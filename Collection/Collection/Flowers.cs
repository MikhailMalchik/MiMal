using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
namespace Collection
{
    class Flowers : Goods, IComparable<Flowers>
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
        public int CompareTo(Flowers o)
        {
            Flowers p = o as Flowers;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("These objects cannot compare");
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
