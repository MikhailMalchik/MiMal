using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    abstract class Candy : Object, Goods, Product
    {
        public int callories { get; set; }
        public string Name { get; set; }
        public string Yummy { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public virtual void GetCandyInf()
        {
            Console.WriteLine($"Name: {Name},Type: {Type}, Cost: {Cost}, callories: {callories}, Yummy: {Yummy}");
        }
        protected Candy(string Type, int callories, int Cost, string Yummy)
        {
            Name = "Candy";
            this.Type = Type;
            this.callories = callories;
            this.Cost = Cost;
            this.Yummy = Yummy;
        }
        public override string ToString()
        {
            return base.ToString() + "Tostring candy";
        }
    }
}
