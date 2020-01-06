using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    abstract class Candy : Object, Goods, Product
    {
        public int callories { get; set; }
        public string Name { get; set; }
        public string Yummy { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Size { get; set; }
        public virtual void GetCandyInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost}, callories: {callories}, Yummy: {Yummy},Size: {Size}");
        }
        protected Candy(string Type, int callories, int Cost, string Yummy, int Size)
        {
            Name = "Candy";
            this.Type = Type;
            this.callories = callories;
            this.Cost = Cost;
            this.Yummy = Yummy;
            this.Size = Size;
        }
        public override string ToString()
        {
            return base.ToString() + "Tostring candy";
        }
        
    }
}
