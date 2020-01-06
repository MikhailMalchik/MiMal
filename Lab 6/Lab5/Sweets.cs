using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    sealed class Sweets : Candy
    {
        public Sweets(string Type, int callories, int Cost, string Yummy, int Size) : base(Type, callories, Cost, Yummy, Size)
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
