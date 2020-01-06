using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    sealed class Cake : Candy
    {
        public Cake(string Type, int callories, int Cost, string Yummy, int Size):base ( Type, callories,  Cost,  Yummy, Size)
        {
            if (Yummy == "Not yummy")
                throw new trycatch2("Вы сказали что это не вкусно!!!");
            else
                Yummy = Yummy;
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
