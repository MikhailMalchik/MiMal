using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    sealed class Sweets : Candy
    {
        public Sweets(string Type, int callories, int Cost, string Yummy) : base(Type, callories, Cost, Yummy)
        {

        }
        public override string ToString()
        {
            return "Sweets";
        }
        public override void GetCandyInf()
        {
            base.GetCandyInf();
        }
    }
}
