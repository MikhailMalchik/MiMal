using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    sealed class Cake : Candy
    {
        public Cake(string Type, int callories, int Cost, string Yummy, int Size):base ( Type, callories,  Cost,  Yummy, Size)
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
