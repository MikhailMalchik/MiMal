using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    sealed class Cake : Candy
    {
        public Cake(string Type, int callories, int Cost, string Yummy):base ( Type, callories,  Cost,  Yummy)
        {

        }
        public override string ToString()
        {
            return "Cake";
        }
        public override void GetCandyInf()
        {
            base.GetCandyInf();
        }
    }
}
